using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class ControlSliderVMPage : ContentPage
{
    public ControlSliderVMPage()
    {
        InitializeComponent();
        BindingContext = new ControlSliderVMViewModel();

    }
}