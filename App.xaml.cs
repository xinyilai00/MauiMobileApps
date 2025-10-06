using MauiMobileApps.View;

namespace MauiMobileApps
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            //MainPage = new MainPage();
            //MainPage = new NavigationPage(new MainPage());
        }
    }
}
