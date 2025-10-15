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
        [RelayCommand]
        private async Task VerticalStackLayoutsClicked()
        {
            await Shell.Current.GoToAsync(nameof(VerticalStackLayoutPage));
        }
        public LayoutsViewModel()
        {
            //Title = TitleLayouts.Title;
        }
        
    }
}
