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

        [ObservableProperty]
        private ImageSource imageSourceURL;

        public ImagesURIViewModel()
        {
            ImageSourceURL = new UriImageSource
            {
                Uri = new Uri(TitleURI.ImageURL),
                CachingEnabled = true,
                CacheValidity = TimeSpan.FromDays(1)
            };
        }


    }
}
