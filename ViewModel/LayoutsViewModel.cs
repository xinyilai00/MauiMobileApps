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
            await Shell.Current.GoToAsync(nameof(LayoutsStackPage));
        }
        [RelayCommand]
        private async Task VerticalStackLayoutsClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutsVerticalPage));
        }

        [RelayCommand]
        private async Task HorizontalStackLayoutsClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutHorizontalPage));
        }
        
        [RelayCommand]
        private async Task AbsoluteStackLayoutsClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutAbsolutePage));
        }
        [RelayCommand]
        private async Task FlexLayoutsClicked()
        {
            await Shell.Current.GoToAsync(nameof(LayoutFlexPage));
        }
        public LayoutsViewModel()
        {
            //Title = TitleLayouts.Title;
        }
        
    }
}
