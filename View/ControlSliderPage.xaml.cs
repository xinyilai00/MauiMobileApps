using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class ControlSliderPage : ContentPage
{
	public ControlSliderPage()
	{
		InitializeComponent();
		BindingContext = new ControlSliderViewModel();
	}
}