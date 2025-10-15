using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMobileApps.ViewModel
{
    public class VerticalStackLayoutsViewModel : ContentPage
    {
        public VerticalStackLayoutsViewModel()
        {
            Content = new VerticalStackLayout
            {
                Children =
                {
                    new Label {HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center}
                }
            };
        }
    }
}
