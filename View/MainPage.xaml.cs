using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
    }
}