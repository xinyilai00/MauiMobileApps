using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class LayoutsStackPage : ContentPage
{
	public LayoutsStackPage()
	{
		InitializeComponent();
        BindingContext = new LayoutsStackViewModel();
    }
}