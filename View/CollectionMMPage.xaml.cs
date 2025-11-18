using MauiMobileApps.ViewModel;
namespace MauiMobileApps.View;

public partial class CollectionMMPage : ContentPage
{
	public CollectionMMPage()
	{
		InitializeComponent();
        BindingContext = new CollectionMMViewModel();
    }
}