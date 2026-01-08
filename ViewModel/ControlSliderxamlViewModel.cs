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
    public partial class ControlSliderxamlViewModel : ObservableObject
    {
        public string Title => TitleControls.Sxpage;

        [ObservableProperty]
        private double sliderValue = 0.5;
    }
}
