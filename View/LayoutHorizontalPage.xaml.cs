using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class LayoutHorizontalPage : ContentPage
{
	public LayoutHorizontalPage()
	{
		InitializeComponent();
        BindingContext = new LayoutHorizontalViewModel();
    }
}