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
    public partial class ControlSliderViewModel : ObservableObject
    {
        public string Title => TitleControls.Spage;

        [ObservableProperty]
        private string sliderxaml = TitleControls.Xaml;

        [ObservableProperty]
        private string slidervm = TitleControls.Vm;

        [RelayCommand]
        private async Task SliderxamlClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlSliderxamlPage));
        }

        [RelayCommand]
        private async Task SlidervmClicked()
        {
            await Shell.Current.GoToAsync(nameof(ControlSliderVMPage));
        }
    }
}
