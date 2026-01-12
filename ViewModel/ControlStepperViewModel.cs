using CommunityToolkit.Mvvm.ComponentModel;
using MauiMobileApps.Model.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMobileApps.ViewModel
{
    public partial class ControlStepperViewModel : ObservableObject
    {
        public string Title => TitleControls.Stpage;

        [ObservableProperty]
        private int stepperValue;
    }
}
