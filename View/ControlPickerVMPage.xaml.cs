using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class ControlPickerVMPage : ContentPage
{
	public ControlPickerVMPage()
	{
		InitializeComponent();
        BindingContext = new ControlPickerVMViewModel();
    }
}