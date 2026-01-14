using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class ControlEntryResult : ContentPage
{
	public ControlEntryResult()
	{
		InitializeComponent();
		BindingContext = new ControlEntryResultViewModel();
    }
}