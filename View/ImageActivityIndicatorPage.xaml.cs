using MauiMobileApps.ViewModel;
namespace MauiMobileApps.View;

public partial class ImageActivityIndicatorPage : ContentPage
{
	public ImageActivityIndicatorPage()
	{
		InitializeComponent();
		BindingContext = new ImagesActivityViewModel();
    }
}