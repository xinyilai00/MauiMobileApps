using MauiMobileApps.Model.Titles;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiMobileApps.ViewModel;
using MauiMobileApps.View;

namespace MauiMobileApps.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
     
        [ObservableProperty]
        private string layouts = TitleMain.Layouts;

        [ObservableProperty]
        private string images = TitleMain.Images;

        [ObservableProperty]
        private string collections = TitleMain.Collections;

        [ObservableProperty]
        private string controls = TitleMain.Controls;

        [ObservableProperty]
        private string sQLLite = TitleMain.SQLLite;

        [ObservableProperty]
        private string title = TitleMain.Title;

        [RelayCommand]
        private async Task LayoutsClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutsPage));
        }

        [RelayCommand]
        private async Task ImagesClicked()
        {
            await Shell.Current.GoToAsync(nameof(ImagesPage));
        }
        public MainViewModel()
        {
            //Title = TitleMain.Title;

            //Set Commands
            //OnLayoutsClicked = new Command(OnLayoutsClickedAsync);
        }

        //public string Layouts { get; set; } = TitleMain.Layouts;
        //public string Images { get; set; } = TitleMain.Images;
        //public string Collections { get; set; } = TitleMain.Collections;
        //public string Controls { get; set; } = TitleMain.Controls;
        //public string SQLLite { get; set; } = TitleMain.SQLLite;

        //Button Commands
        //public ICommand OnLayoutsClicked { get; set; }

        //private async void OnLayoutsClickedAsync()
        //{
        //await Application.Current.MainPage.Navigation.PushAsync(new View.LayoutsPage());
        // }
    }
}
