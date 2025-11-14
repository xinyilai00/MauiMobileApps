using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiMobileApps.Model.Titles;
using MauiMobileApps.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMobileApps.ViewModel
{
    public partial class ImagesViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleImages.Title;

        [ObservableProperty]
        private string uri = TitleImages.URI;

        [ObservableProperty]
        private string embedded = TitleImages.Embedded;

        [RelayCommand]
        private async Task URIImageClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesURIPage));
        }

        [RelayCommand]
        private async Task EmbeddedImageClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesEmbeddedPage));
        }

        [RelayCommand]
        private async Task ActivityImageClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImageActivityIndicatorPage));
        }
        public ImagesViewModel()
        {

        }
    }
}
