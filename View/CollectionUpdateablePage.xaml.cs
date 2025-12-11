using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class CollectionUpdateablePage : ContentPage
{
	public CollectionUpdateablePage(CollectionUpdateableViewModel vm)
	{
        InitializeComponent();
        BindingContext = vm;
    }
}