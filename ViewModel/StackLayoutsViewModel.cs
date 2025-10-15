using MauiMobileApps.Model.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMobileApps.ViewModel
{
    public class StackLayoutsViewModel : ContentPage
    {
        public StackLayoutsViewModel()
        {
            Content = new VerticalStackLayout
            {
                Children =
                {
                    new Label {HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"}
                }
            };
        }
    }
}
