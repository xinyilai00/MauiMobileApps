using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class ControlPickerResult : ContentPage
{
	public ControlPickerResult()
	{
		InitializeComponent();
        BindingContext = new ControlPickerResultViewModel();
    }
}