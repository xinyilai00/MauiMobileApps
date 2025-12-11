using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class CollectionAddPage : ContentPage
{
	public CollectionAddPage()
	{
        InitializeComponent();
        BindingContext = new CollectionAddViewModel();
    }
}