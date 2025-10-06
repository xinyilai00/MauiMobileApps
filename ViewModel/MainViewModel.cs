using MauiMobileApps.Model.Titles;
using MyFirstMobileApp.ViewModels;
using System.Windows.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiMobileApps.ViewModel;

namespace MauiMobileApps.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public string Layouts { get; set; } = TitleMain.Layouts;
        public string Images { get; set; } = TitleMain.Images;
        public string Collections { get; set; } = TitleMain.Collections;
        public string Controls { get; set; } = TitleMain.Controls;
        public string SQLLite { get; set; } = TitleMain.SQLLite;

        //Button Commands
        public ICommand OnLayoutsClicked { get; set; }
        public MainViewModel()
        {
            Title = TitleMain.Title;

            //Set Commands
            OnLayoutsClicked = new Command(OnLayoutsClickedAsync);
        }

        private async void OnLayoutsClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new View.LayoutsPage());
        }
    }
}
