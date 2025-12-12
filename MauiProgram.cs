using CommunityToolkit.Maui;
using MauiMobileApps.View;
using MauiMobileApps.ViewModel;
using Microsoft.Extensions.Logging;

namespace MauiMobileApps
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            try
            {
                builder.Services.AddSingleton<CollectionUpdateableViewModel>();
                builder.Services.AddSingleton<CollectionUpdateablePage>();
            }
            catch (Exception ex)
            {

            }
            return builder.Build();
        }
    }
}
