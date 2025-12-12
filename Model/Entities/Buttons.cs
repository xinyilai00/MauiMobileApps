using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls; 

namespace MauiMobileApps.Model.Entities
{
    public class Buttons
    {
        public static ImageSource IconsEdit { get; } = ImageSource.FromFile("iconsedit.png");
        public static ImageSource IconsDelete { get; } = ImageSource.FromFile("iconsdelete.png");
    }
}
