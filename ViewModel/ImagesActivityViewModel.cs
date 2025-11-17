using CommunityToolkit.Mvvm.ComponentModel;
using MauiMobileApps.Model.Titles;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace MauiMobileApps.ViewModel
{
    public partial class ImagesActivityViewModel : ObservableObject
    {
        public string Title = TitleActivity.Title;

        [ObservableProperty]
        private bool isLoading = true;

        [ObservableProperty]
        private bool isImageVisible = true;

        [ObservableProperty]
        private ImageSource loadedImage;

        public ImagesActivityViewModel()
        {
            _ = LoadImageAsync();
        }

        private async Task LoadImageAsync()
        {
            try
            {
                using var client = new HttpClient();
                var response = await client.GetAsync(TitleURI.ImageURL);

                if (response.IsSuccessStatusCode)
                {
                    var stream = await response.Content.ReadAsStreamAsync();
                    LoadedImage = ImageSource.FromStream(() => stream);
                    IsImageVisible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: { ex.Message}");
            }
            finally
            {
                IsLoading = false;
            }
        }

    }
}
