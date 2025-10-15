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
            Routing.RegisterRoute(nameof(VerticalStackLayoutPage), typeof(VerticalStackLayoutPage));
        }
    }
}
