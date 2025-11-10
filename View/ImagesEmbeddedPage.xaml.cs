using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class ImagesEmbeddedPage : ContentPage
{
	public ImagesEmbeddedPage()
	{
		InitializeComponent();
		BindingContext = new ImagesEmbeddedViewModel();
    }
}