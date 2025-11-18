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
    public partial class CollectionsViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleCollections.Title;

        [ObservableProperty]
        private string collection = TitleCollections.Collection;

        [ObservableProperty]
        private string images = TitleCollections.Images;

        [ObservableProperty]
        private string buttons = TitleCollections.Buttons;

        [ObservableProperty]
        private string icons = TitleCollections.Icons;

        [RelayCommand]
        private async Task CollectionClicked()
        {
            await Shell.Current.GoToAsync(nameof(CollectionMMPage));
        }

        [RelayCommand]
        private async Task ImagesCollectionClicked()
        {
            await Shell.Current.GoToAsync(nameof(CollectionGOGwImagesPage));
        }

        [RelayCommand]
        private async Task ButtonsCollectionClicked()
        {
            //await Shell.Current.GoToAsync(nameof());
        }

        [RelayCommand]
        private async Task IconsCollectionClicked()
        {
            //await Shell.Current.GoToAsync(nameof());
        }

        public CollectionsViewModel()
        {

        }
    }
}
