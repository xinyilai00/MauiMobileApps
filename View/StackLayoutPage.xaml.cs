using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class StackLayoutPage : ContentPage
{
	public StackLayoutPage()
	{
		InitializeComponent();
        BindingContext = new StackLayoutsViewModel();
    }
}