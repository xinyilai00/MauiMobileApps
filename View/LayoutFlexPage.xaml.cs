using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class LayoutFlexPage : ContentPage
{
	public LayoutFlexPage()
	{
		InitializeComponent();
        BindingContext = new LayoutFlexViewModel();
    }
}