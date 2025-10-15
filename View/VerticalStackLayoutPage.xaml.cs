using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class VerticalStackLayoutPage : ContentPage
{
	public VerticalStackLayoutPage()
	{
		InitializeComponent();
        BindingContext = new VerticalStackLayoutsViewModel();
    }
}