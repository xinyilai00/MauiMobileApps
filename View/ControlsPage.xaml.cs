using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class ControlsPage : ContentPage
{
	public ControlsPage()
	{
		InitializeComponent();
        BindingContext = new ControlsViewModel();
    }
}