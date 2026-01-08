using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiMobileApps.Model.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMobileApps.ViewModel
{
    public partial class ControlSliderVMViewModel : ObservableObject
    {
        public string Title => TitleControls.Svpage;

        [ObservableProperty]
        private double sliderValue;

        [RelayCommand]
        private void SetToHalf()
        {
            SliderValue = 0.5;
        }
    }
}
