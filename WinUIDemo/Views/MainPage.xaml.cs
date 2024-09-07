using Microsoft.UI.Xaml.Controls;

using WinUIDemo.ViewModels;

namespace WinUIDemo.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
