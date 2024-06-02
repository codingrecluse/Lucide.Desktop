using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Lucide.WPF;
using Lucide.WPF.Enums;
using System.Drawing;
using System.Windows.Media;
using Wpf.Views;

namespace Wpf.ViewModels;
internal class MainWindowViewModel : ObservableObject
{
  public IRelayCommand OnLoaded { get; set; }
  public IRelayCommand OnSelectCategory { get; set; }
  public IRelayCommand OnColorPickerButtonClick { get; set; }

  private ImageSource _colorPickerButtonIcon; public ImageSource ColorPickerIcon
  {
    get => _colorPickerButtonIcon;
    set => SetProperty(ref _colorPickerButtonIcon, value);
  }
  private List<IconCategory>? _categories = new(); public List<IconCategory>? Categories
  {
    get => _categories;
    set => SetProperty(ref _categories, value);
  }
  private List<ImageSource>? _icons = new List<ImageSource>(); public List<ImageSource>? Icons
  {
    get => _icons;
    set => SetProperty(ref _icons, value);
  }
  private ImageSource? _image; public ImageSource? SelectedIcon
  {
    get => _image;
    set => SetProperty(ref _image, value);
  }
  private System.Windows.Media.SolidColorBrush _selectedColor = System.Windows.Media.Brushes.Black; public System.Windows.Media.SolidColorBrush SelectedColor
  {
    get => _selectedColor;
    set => SetProperty(ref _selectedColor, value);
  } 
  private int _height = 128; public int IconHeight //Larger base size for better image versatility
  {
    get => _height;
    set
    {
      IconWidth = value;
      SetProperty(ref _height, value);
      HandleCategorySelect();
    }
  } 
  private int _width = 128; public int IconWidth //Larger base size for better image versatility
  {
    get => _width;
    set
    {
      SetProperty(ref _width, value);
      HandleCategorySelect();
    }
  } 
  private IconCategory _selectedCategory = IconCategory.NULL; public IconCategory SelectedCategory
  {
    get => _selectedCategory;
    set => SetProperty(ref _selectedCategory, value);
  }

  public MainWindowViewModel()
  {
    OnLoaded = new AsyncRelayCommand(HandleLoaded);
    OnSelectCategory = new AsyncRelayCommand(HandleCategorySelect);
    OnColorPickerButtonClick = new AsyncRelayCommand(OpenColorPicker);

    ParseCategories();
  }

  private async Task OpenColorPicker()
  {
    var colorPicker = new ColorPickerWindow();
    var viewModel = new ColorPickerViewModel();

    colorPicker.DataContext = viewModel;
    colorPicker.Owner = App.Current.MainWindow;
    colorPicker.ShowDialog();

    SelectedColor = viewModel.SelectedColor.Value;

    await HandleCategorySelect();
  }

  private void ParseCategories()
  {
    var strings = Enum.GetNames<IconCategory>();
    foreach (var name in strings)
    {
      Categories.Add(Enum.Parse<IconCategory>(name));
    }
  }

  private async Task HandleIconSelect(ImageSource? icon)
  {
    SelectedIcon = icon;
  }

  private async Task HandleLoaded()
  {
    ColorPickerIcon = await IconManager.CreateImageSource(IconName.palette);
  }
  private async Task HandleCategorySelect()
  {
    var iconNames = await IconManager.FilterIconsByCategory(SelectedCategory);
    Icons?.Clear();
    var result = new List<ImageSource>();
    foreach (var name in iconNames ?? [])
    {
      var converter = new BrushConverter();
      
      var icon = await IconManager.CreateImageSource(name, SelectedColor.Color, IconHeight, IconWidth);
      if (icon != null)
        result.Add(icon);
    }

    Icons = result;
  }

}
