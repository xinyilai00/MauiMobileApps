using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class ImagesURIPage : ContentPage
{
	public ImagesURIPage()
	{
		InitializeComponent();
        BindingContext = new ImagesURIViewModel();
    }
}