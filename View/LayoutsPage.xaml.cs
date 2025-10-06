using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class LayoutsPage : ContentPage
{
	public LayoutsPage()
	{
		InitializeComponent();
		BindingContext = new LayoutsViewModel();
    }
}