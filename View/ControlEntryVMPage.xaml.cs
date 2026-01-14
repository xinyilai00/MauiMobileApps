using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class ControlEntryVMPage : ContentPage
{
	public ControlEntryVMPage()
	{
		InitializeComponent();
		BindingContext = new ControlEntryVMViewModel();
	}
}