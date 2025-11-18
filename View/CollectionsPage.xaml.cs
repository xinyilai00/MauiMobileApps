using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class CollectionsPage : ContentPage
{
	public CollectionsPage()
	{
		InitializeComponent();
		BindingContext = new CollectionsViewModel();

    }
}