using Lucide.WPF;
using Lucide.WPF.Enums;
using System.Windows.Navigation;

namespace Forms;

public partial class IconDisplay : Form
{
  private Color selectedColor = Color.Black;
  private List<IconCategory> categories = new List<IconCategory>();
  private int iconSize = 48;
  public IconDisplay()
  {
    InitializeComponent();
  }

  private void ColorPickerButton_Click(object sender, EventArgs e)
  {
    colorDialog1.ShowDialog();
    selectedColor = colorDialog1.Color;
    CategoryCombo_SelectionChangeCommitted(null, new EventArgs());
  }

  private async void CategoryCombo_SelectionChangeCommitted(object? sender, EventArgs e)
  {
    if (categoryCombo.SelectedItem == null)
      return;
    var selectedCategory =  (IconCategory)categoryCombo.SelectedItem;

    var iconnames = await IconManager.FilterIconsByCategory(selectedCategory);

    workingImageList.Images.Clear();
    workingImageList.ImageSize = new Size(iconSize, iconSize);
    foreach (var name in iconnames)
    {
      workingImageList.Images.Add(await IconManager.CreateImage(name, selectedColor, iconSize, iconSize));
    }
    iconListView.Items.Clear();
    iconListView.LargeImageList = workingImageList;

    var imgIndex = 0;
    foreach (var icon in workingImageList.Images)
    {
      var item = new ListViewItem("", imgIndex++);
      iconListView.Items.Add(item);
    }
  }

  private async void IconDisplay_Load(object sender, EventArgs e)
  {
    var strings = Enum.GetNames<IconCategory>();
    foreach (var name in strings)
    {
      categories.Add(Enum.Parse<IconCategory>(name));
    }

    foreach (var category in categories)
    {
      categoryCombo.Items.Add(category);
    }
    categoryCombo.DisplayMember = "Key";
    categoryCombo.ValueMember = "Value";

    colorPickerButton.Image = await IconManager.CreateImage(IconName.palette, Color.Black, 16, 16);

    categoryCombo.SelectedItem = IconCategory.accessibility;
    CategoryCombo_SelectionChangeCommitted(null, new EventArgs());
  }

  private void IconHeightText_TextChanged(object sender, EventArgs e)
  {
    int.TryParse(iconHeightText.Text, out int value);
    if(value > 0 && value < 256)
    {
      iconSize = value;
      CategoryCombo_SelectionChangeCommitted(null, new EventArgs());
    }
    else
    {
      iconHeightText.Text = "256";
      iconSize = 256;
      MessageBox.Show("Size cannot exceed 256 x 256");
    }
  }
}
