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
    public partial class CollectionGOGwImagesViewModel : ObservableObject
    {
        private List<GOGActors> _gogactors;
        public string title => TitleGOG.Title;
        public ObservableCollection<GOGActors> GOGActorsCollection { get; } = new();

        public CollectionGOGwImagesViewModel()
        {
            _gogactors = GOGActors.GetActor();
            LoadActor();
        }

        private void LoadActor()
        {
            try
            {
                GOGActorsCollection.Clear();
                foreach (var p in _gogactors)
                {
                    GOGActorsCollection.Add(new GOGActors { NameofActor = p.NameofActor });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

    }
}
