using MauiMobileApps.ViewModel;

namespace MauiMobileApps.View;

public partial class ControlSliderxamlPage : ContentPage
{
	public ControlSliderxamlPage()
	{
		InitializeComponent();
        BindingContext = new ControlSliderxamlViewModel();

        UpdateVisuals(MySlider.Value);
        SetPlatformPadding();
    }
    private void OnSliderValueChange(object sender, ValueChangedEventArgs e) => UpdateVisuals(e.NewValue);

    private void UpdateVisuals(double value)
    {
        MyBox.Opacity = value;

        ValueLabel.Text = $"Value of the slider is {value:F2}";

        InfoLabel.Opacity = value;
    }
    private void SetPlatformPadding()
    {
        if (DeviceInfo.Platform == DevicePlatform.iOS || DeviceInfo.Platform == DevicePlatform.Android)
        {
            Padding = new Thickness(25);
        }
        else
        {
            Padding = Thickness.Zero;
        }
    }
}