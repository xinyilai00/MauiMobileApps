using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class ImagesPage : ContentPage
{
	public ImagesPage()
	{
		InitializeComponent();
        BindingContext = new ImagesViewModel();
    }
}