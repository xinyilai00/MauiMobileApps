using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MauiMobileApps.Model.Entities;
using MauiMobileApps.Model.Messages;
using MauiMobileApps.Model.Titles;
using MauiMobileApps.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMobileApps.ViewModel
{
    public partial class CollectionUpdateableViewModel : ObservableObject
    {
        // flag for pull-to-refresh
        [ObservableProperty] private bool isBusy;

        // page title
        [ObservableProperty] private string title;

        // the list bound to CollectionView.ItemsSource
        [ObservableProperty]
        private ObservableCollection<MarvelMovies> movieCollection = new();

        public CollectionUpdateableViewModel()
        {
            Title = TitleCollections.Title;

            // central listener for any UpdateMovieMessage
            WeakReferenceMessenger.Default.Register<UpdateMovieMessage>(this, (r, m) =>
            {
                var oldTitle = m.OldValue.NameofMovie;
                var idx = MovieCollection.ToList()
                                         .FindIndex(x => x.NameofMovie == oldTitle);
                if (idx >= 0)
                    MovieCollection[idx] = m.NewValue;
            });

            // kick off initial load
            RefreshCommand.Execute(null);
        }

        /// <summary>
        /// Reloads the in-memory list from your static data.
        /// </summary>
        [RelayCommand]
        private async Task Refresh()
        {
            if (IsBusy) return;
            IsBusy = true;

            // Use Task.Run to perform the CPU-bound work on a background thread
            await Task.Run(() =>
            {
                MovieCollection.Clear();
                foreach (var mov in MarvelMovies.GetMovies())
                {
                    // Adding items to the collection
                    MovieCollection.Add(mov);
                }
            });

            IsBusy = false;
        }

        /// <summary>
        /// Navigate to AddCollectionPage, then await an AddMovieMessage.
        /// </summary>
        [RelayCommand]
        private async Task Add()
        {
            WeakReferenceMessenger.Default.Unregister<AddMovieMessage>(this);

            await Shell.Current.GoToAsync(nameof(CollectionAddPage));

            WeakReferenceMessenger.Default.Register<AddMovieMessage>(this, (r, m) =>
            {
                MovieCollection.Add(m.Value);
                WeakReferenceMessenger.Default.Unregister<AddMovieMessage>(this);
            });
        }

        /// <summary>
        /// Navigate to EditCollectionPage with a ?movieName=… query
        /// </summary>
        [RelayCommand]
        private async Task Update(MarvelMovies movie)
        {
            // (No need to register update message here (below), it's already registered in constructor)
            //WeakReferenceMessenger.Default.Unregister<UpdateMovieMessage>(this);
            // Just navigate to the Edit page, encoding the movie name for safe URL transport
            string encodedName = Uri.EscapeDataString(movie.NameofMovie);
            await Shell.Current.GoToAsync($"{nameof(CollectionEditPage)}?movieName={encodedName}");
        }

        /// <summary>
        /// Remove immediately from the list.
        /// </summary>
        [RelayCommand]
        private void Delete(MarvelMovies movie)
        {
            MovieCollection.Remove(movie);
        }
    }
}
