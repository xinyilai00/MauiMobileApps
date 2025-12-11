using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MauiMobileApps.Model.Entities;
using MauiMobileApps.Model.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMobileApps.ViewModel
{
    [QueryProperty(nameof(MovieName), "movieName")]
    public partial class CollectionEditViewModel : ObservableObject
    {
        private string _originalMovieName;
        public string Title => "Edit Movie";

        [ObservableProperty]
        private string movieName;

        partial void OnMovieNameChanged(string value)
        {
            // Store the original movie name when it's first set
            if (_originalMovieName is null)
            {
                _originalMovieName = value;
            }
        }

        [RelayCommand]
        private async Task UpdateClicked()
        {
            // Ensure the MovieName is not empty
            if (string.IsNullOrWhiteSpace(MovieName))
            {
                // Display Error Message to the user
                await Shell.Current.DisplayAlert(
                    Title,
                    Msgs.NotEmptyMovie,
                    "Ok");
                return;
            }

            var oldMovie = new MarvelMovies(_originalMovieName);
            var newMovie = new MarvelMovies(MovieName);

            // Send an UpdateMovieMessage with the old and new movie names
            WeakReferenceMessenger.Default.Send(new UpdateMovieMessage(oldMovie, newMovie));
            // Navigate back to the previous page
            await Shell.Current.GoToAsync("..");
        }
    }
}
