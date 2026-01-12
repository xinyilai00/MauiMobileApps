using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class ControlStepperPage : ContentPage
{
	public ControlStepperPage()
	{
		InitializeComponent();
		BindingContext = new ControlStepperViewModel();
	}
}