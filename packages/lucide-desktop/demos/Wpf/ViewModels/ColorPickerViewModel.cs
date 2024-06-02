using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using Wpf.Views;

namespace Wpf.ViewModels
{
  public class ColorPickerViewModel : ObservableObject
  {
    public IRelayCommand Apply { get; set; }
    public IRelayCommand Cancel { get; set; }
    public EventHandler<SolidColorBrush> OnColorApply;

    private Dictionary<string, SolidColorBrush> _Brushes = new()
        {
            {"Red", Brushes.Red},
            {"Orange", Brushes.Orange},
            {"Yellow", Brushes.Yellow},
            {"Green", Brushes.Green },
            {"Blue", Brushes.Blue },
            {"Indigo", Brushes.Indigo },
            {"Violet", Brushes.Violet },
            {"White", Brushes.White },
        };
    public Dictionary<string, SolidColorBrush> ColorChoices
    {
      get => _Brushes;
      set => SetProperty(ref _Brushes, value);
    }
    private KeyValuePair<string, SolidColorBrush> _selectedColor; public KeyValuePair<string, SolidColorBrush> SelectedColor
    {
      get => _selectedColor;
      set => SetProperty(ref _selectedColor, value);
    }



    public ColorPickerViewModel()
    {
      Apply = new RelayCommand(HandleApply);
      Cancel = new RelayCommand(Close);
    }
    public void HandleApply()
    {
      OnColorApply?.Invoke(this, _Brushes[SelectedColor.Key]);
      Close();
    }
    public void Close()
    {
      Application.Current.Dispatcher.Invoke(() =>
      {
        if (Application.Current.Windows.Count > 0)
        {
          foreach (Window window in Application.Current.Windows)
            if (window.GetType() == typeof(ColorPickerWindow))
              window.Close();
        }
      });
    }
  }
}
