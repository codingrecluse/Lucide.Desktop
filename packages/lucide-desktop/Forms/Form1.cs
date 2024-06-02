using Lucide.WPF;
using Lucide.WPF.Enums;
using System.Windows.Navigation;

namespace Forms;

public partial class Form1 : Form
{
  private Color selectedColor = Color.Black;
  private List<Image> loadedIcons = new List<Image>();
  private List<IconCategory> categories = new List<IconCategory>();
  private int _iconHeight = 48; private int iconHeight
  {
    get => _iconHeight;
    set
    {
      _iconHeight = value;
      iconWidth = value;
    }

  }
  private int iconWidth = 48;
  public Form1()
  {
    InitializeComponent();
  }

  private void button1_Click(object sender, EventArgs e)
  {
    colorDialog1.ShowDialog();
    selectedColor = colorDialog1.Color;
  }

  private async void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
  {
    var selectedCategory = (IconCategory)comboBox1.SelectedItem;
    var iconnames = await IconManager.FilterIconsByCategory(selectedCategory);

    foreach (var name in iconnames)
    {
      loadedIcons.Add(await IconManager.CreateImage(name, selectedColor, iconHeight, iconWidth));
    }

    imageList1.Images.Clear();
    imageList1.Images.AddRange(loadedIcons.ToArray());
    listView1.LargeImageList = imageList1;

    var imgIndex = 0;
    foreach (var icon in loadedIcons)
    {
      var item = new ListViewItem("-", imgIndex++);
      listView1.Items.Add(item);
    }
  }

  private void Form1_Load(object sender, EventArgs e)
  {
    var strings = Enum.GetNames<IconCategory>();
    foreach (var name in strings)
    {
      categories.Add(Enum.Parse<IconCategory>(name));
    }

    foreach (var category in categories)
    {
      comboBox1.Items.Add(category);
    }
    comboBox1.DisplayMember = "Key";
    comboBox1.ValueMember = "Value";
  }

}
