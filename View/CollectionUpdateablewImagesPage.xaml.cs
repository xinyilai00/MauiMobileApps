using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class CollectionUpdateablewImagesPage : ContentPage
{
	public CollectionUpdateablewImagesPage(CollectionUpdateableViewModel vm)
	{
        InitializeComponent();
        BindingContext = vm;
    }
}