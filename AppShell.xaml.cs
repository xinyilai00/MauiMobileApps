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
            Routing.RegisterRoute(nameof(StackLayoutPage), typeof(StackLayoutPage));
        }
    }
}
