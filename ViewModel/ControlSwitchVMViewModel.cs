using CommunityToolkit.Mvvm.ComponentModel;
using MauiMobileApps.Model.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMobileApps.ViewModel
{
    public partial class ControlSwitchVMViewModel : ObservableObject
    {
        public string Title => TitleControls.Swpage;

        [ObservableProperty]
        private Color labelColor;

        [ObservableProperty]
        private bool isOn;

        public ControlSwitchVMViewModel()
        { 
            IsOn = true; 
            LabelColor = Color.FromRgb(0, 0, 255); 
        }
        partial void OnIsOnChanged(bool value)
        {
            LabelColor = value 
                ? Color.FromRgb(0, 0, 255) 
                : Color.FromRgb(255, 0, 0);
        }
        
    }
}
