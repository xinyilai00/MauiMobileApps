using MauiMobileApps.View;

namespace MauiMobileApps
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }
        private void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(LayoutsPage), typeof(LayoutsPage));
            Routing.RegisterRoute(nameof(LayoutsStackPage), typeof(LayoutsStackPage));
            Routing.RegisterRoute(nameof(LayoutsVerticalPage), typeof(LayoutsVerticalPage));
            Routing.RegisterRoute(nameof(LayoutHorizontalPage), typeof(LayoutHorizontalPage));
            Routing.RegisterRoute(nameof(LayoutAbsolutePage), typeof(LayoutAbsolutePage));
            Routing.RegisterRoute(nameof(LayoutFlexPage), typeof(LayoutFlexPage));

            Routing.RegisterRoute(nameof(ImagesPage), typeof(ImagesPage));
            Routing.RegisterRoute(nameof(ImagesURIPage), typeof(ImagesURIPage));
            Routing.RegisterRoute(nameof(ImagesEmbeddedPage), typeof(ImagesEmbeddedPage));
        }
    }
}
