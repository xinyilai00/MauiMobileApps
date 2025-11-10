using CommunityToolkit.Mvvm.ComponentModel;
using MauiMobileApps.Model.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMobileApps.ViewModel
{
    public partial class ImagesURIViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleURI.Title;
    }
}
