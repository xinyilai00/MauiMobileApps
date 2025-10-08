using MauiMobileApps.Model.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMobileApps.ViewModel
{
    class LayoutsViewModel
    {
        public LayoutsViewModel()
        {
            Title = TitleLayouts.Title;
        }
        public string StackLayout { get; set; } = TitleLayouts.StackLayout;
        public string VerticalStack { get; set; } = TitleLayouts.VerticalStack;
        public string HorizontalStack { get; set; } = TitleLayouts.HorizontalStack;
        public string AbsoluteLayout { get; set; } = TitleLayouts.AbsoluteLayout;
        public string FlexLayout { get; set; } = TitleLayouts.FlexLayout;
        public string Title { get; }
    }
}
