using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiMobileApps.Model.Titles;
using MauiMobileApps.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMobileApps.ViewModel
{
    public partial class ControlsViewModel : ObservableObject
    {
        public string Title => TitleControls.Title;

        [ObservableProperty]
        private string slider = TitleControls.Slider;

        [ObservableProperty]
        private string stepper = TitleControls.Stepper;

        [ObservableProperty]
        private string switchs = TitleControls.Switch;

        [ObservableProperty]
        private string entry = TitleControls.Entry;

        [ObservableProperty]
        private string picker = TitleControls.Picker;

        [ObservableProperty]
        private string date = TitleControls.Date;


        [RelayCommand]
        private async Task SliderClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlSliderPage));
        }

        [RelayCommand]
        private async Task StepperClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlStepperPage));
        }

        [RelayCommand]
        private async Task SwitchClicked()
        {
            //await Shell.Current.GoToAsync(nameof());
        }

        [RelayCommand]
        private async Task EntryClicked()
        {
            //await Shell.Current.GoToAsync(nameof());
        }

        [RelayCommand]
        private async Task PickerClicked()
        {
            //await Shell.Current.GoToAsync(nameof());
        }

        [RelayCommand]
        private async Task DateClicked()
        {
            //await Shell.Current.GoToAsync(nameof());
        }


    }
}
