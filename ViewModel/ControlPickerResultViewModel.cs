using CommunityToolkit.Mvvm.ComponentModel;
using MauiMobileApps.Model.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMobileApps.ViewModel
{
    [QueryProperty(nameof(PickerSelection), "car")]
    [QueryProperty(nameof(RawImagePath), "image")]

    [QueryProperty(nameof(PickerSelection), "actorName")]
    [QueryProperty(nameof(RawImagePath), "actorImage")]

    public partial class ControlPickerResultViewModel : ObservableObject
    {
        public string Title => TitleControls.Ppage;

        private string _pickerSelection;
        public string PickerSelection
        {
            get => _pickerSelection;
            set => SetProperty(ref _pickerSelection, Uri.UnescapeDataString(value ?? string.Empty));
        }

        private string _rawImagePath;
        public string RawImagePath
        {
            get => _rawImagePath;
            set
            {
                if (SetProperty(ref _rawImagePath, value))
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        var file = Uri.UnescapeDataString(value);
                        ImageSrc = ImageSource.FromFile(file);
                    }
                    else
                    {
                        ImageSrc = null;
                    }
                }
            }
        }

        private ImageSource _imageSrc;
        public ImageSource ImageSrc
        {
            get => _imageSrc;
            private set => SetProperty(ref _imageSrc, value);
        }

    }

}
