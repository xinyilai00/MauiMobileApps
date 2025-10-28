using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class LayoutAbsolutePage : ContentPage
{
	public LayoutAbsolutePage()
	{
		InitializeComponent();
		BindingContext = new LayoutAbsoluteViewModel();
    }
}