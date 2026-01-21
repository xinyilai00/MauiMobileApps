using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiMobileApps.Model.Titles;
using MauiMobileApps.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMobileApps.ViewModel
{
    public partial class ControlEntryVMViewModel : ObservableObject
    {
        public string Title => TitleControls.Epage;

        [ObservableProperty]
        private string entryText;

        [RelayCommand]
        private async Task EntryClicked()
        {
            if (string.IsNullOrWhiteSpace(EntryText))
            {
                await Shell.Current.DisplayAlert(TitleControls.Epage,
                                                "Entry is empty. Please enter text.",
                                                "OK");
                return;
            }

            await Shell.Current.GoToAsync($"{nameof(ControlEntryResult)}?entryText={EntryText}");
        }

    }
}
