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
    public partial class ControlSliderViewModel : ObservableObject
    {
        public string Title => TitleControls.SPage;

        [ObservableProperty]
        private double sliderValue = 0.5;

        [RelayCommand]
        private void SetToHalf()
        {

        }
    }
}
