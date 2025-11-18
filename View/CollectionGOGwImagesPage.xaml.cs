using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class CollectionGOGwImagesPage : ContentPage
{
	public CollectionGOGwImagesPage()
	{
		InitializeComponent();
        BindingContext = new CollectionGOGwImagesViewModel();
    }
}