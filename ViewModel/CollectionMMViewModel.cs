using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiMobileApps.Model.Entities;
using MauiMobileApps.Model.Titles;
using MauiMobileApps.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMobileApps.ViewModel
{
    public partial class CollectionMMViewModel : ObservableObject
    {
        private List<MarvelMovies> _marvelmovies;
        public string title => TitleMM.Title;
        public ObservableCollection<MarvelMovies> MarvelMoviesCollection { get; } = new();


        public CollectionMMViewModel()
        {
            _marvelmovies = MarvelMovies.GetMovies();
            LoadMovies();
        }

        private void LoadMovies()
        {
            try
            {
                MarvelMoviesCollection.Clear();
                foreach (var p in _marvelmovies)
                {
                    MarvelMoviesCollection.Add(new MarvelMovies { NameofMovie = p.NameofMovie });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
