using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class ControlSwitchVMPage : ContentPage
{
	public ControlSwitchVMPage()
	{
		InitializeComponent();
		BindingContext = new ControlSwitchVMViewModel();
    }
}