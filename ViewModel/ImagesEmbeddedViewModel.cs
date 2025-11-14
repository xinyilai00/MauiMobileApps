using CommunityToolkit.Mvvm.ComponentModel;
using MauiMobileApps.Model.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMobileApps.ViewModel
{
    public partial class ImagesEmbeddedViewModel : ObservableObject
    {
        public string Title => TitleEmbedded.Title;

        public ImageSource ImageSource => "banana.jpg";

    }
}
