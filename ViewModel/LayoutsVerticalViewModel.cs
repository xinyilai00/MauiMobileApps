using CommunityToolkit.Mvvm.ComponentModel;
using MauiMobileApps.Model.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMobileApps.ViewModel
{
    public partial class LayoutsVerticalViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleLayoutVerticalStack.Title;
    }
}
