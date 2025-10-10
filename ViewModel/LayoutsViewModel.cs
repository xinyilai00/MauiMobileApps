using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiMobileApps.Model.Titles;
using MauiMobileApps.View;
using System.Windows.Input;

namespace MauiMobileApps.ViewModel
{
    public partial class LayoutsViewModel: ObservableObject
    {
        [ObservableProperty]
        private string stackLayout = TitleLayouts.StackLayout;

        [ObservableProperty]
        private string verticalStack = TitleLayouts.VerticalStack;

        [ObservableProperty]
        private string horizontalStack = TitleLayouts.HorizontalStack;

        [ObservableProperty]
        private string absoluteLayout = TitleLayouts.AbsoluteLayout;

        [ObservableProperty]
        private string flexLayout = TitleLayouts.FlexLayout;

        [ObservableProperty]
        private string title = TitleLayouts.Title;

        [RelayCommand]
        private async Task StackLayoutsClicked()
        {
            await Shell.Current.GoToAsync(nameof(StackLayoutPage));
        }
        public LayoutsViewModel()
        {
            //Title = TitleLayouts.Title;
        }
        //public string StackLayout { get; set; } = TitleLayouts.StackLayout;
        // public string VerticalStack { get; set; } = TitleLayouts.VerticalStack;
        //public string HorizontalStack { get; set; } = TitleLayouts.HorizontalStack;
        //public string AbsoluteLayout { get; set; } = TitleLayouts.AbsoluteLayout;
        //public string FlexLayout { get; set; } = TitleLayouts.FlexLayout;
        //public string Title { get; }
    }
}
