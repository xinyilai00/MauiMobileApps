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
        public string Title => TitleURI.Title;

        [ObservableProperty]
        private ImageSource imageSourceUrl;

        public ImagesURIViewModel()
        {
            imageSourceUrl = new UriImageSource
            {
                Uri = new Uri(TitleURI.ImageURL),
                CachingEnabled = true,
                CacheValidity = TimeSpan.FromDays(1)
            };
        }


    }
}
