using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Lucide.WPF;
using Lucide.WPF.Enums;
using System.Drawing;
using System.Windows.Media;

namespace Wpf;
internal class MainWindowViewModel : ObservableObject
{
    public IRelayCommand OnLoaded { get; set; }
    public IRelayCommand<IconCategory> OnSelectCategory { get; set; }
    public IRelayCommand<ImageSource> OnSelectIcon { get; set; }
    private List<IconCategory>? _categories = new(); public List<IconCategory>? Categories
    {
        get => _categories;
        set => SetProperty(ref _categories, value);
    }
    private List<ImageSource>? _icons; public List<ImageSource>? Icons
    {
        get => _icons;
        set => SetProperty(ref _icons, value);
    }
    private ImageSource? _image; public ImageSource? SelectedIcon
    {
        get => _image;
        set => SetProperty(ref _image, value);
    }
    public MainWindowViewModel()
    {
        OnLoaded = new AsyncRelayCommand(HandleLoaded);
        OnSelectCategory = new AsyncRelayCommand<IconCategory>(HandleCategorySelect);
        OnSelectIcon = new AsyncRelayCommand<ImageSource>(HandleIconSelect);

        ParseCategories();
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
        await HandleCategorySelect(IconCategory.brands);
        //await HandleIconSelect(IconName.airplay);
    }
    private async Task HandleCategorySelect(IconCategory category)
    {
        var iconNames = await IconManager.FilterIconsByCategory(category);
        Icons = new List<ImageSource>();
        foreach (var name in iconNames ?? [])
        {
            var icon = await IconManager.CreateImageSource(name);
            if (icon != null)
                Icons.Add(icon);
        }
    }

}
