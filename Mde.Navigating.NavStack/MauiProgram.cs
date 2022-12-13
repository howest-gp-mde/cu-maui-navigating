using Mde.Navigating.NavStack.Models;
using Microsoft.Extensions.Logging;

namespace Mde.Navigating.NavStack
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            Routing.RegisterRoute("//home/weather", typeof(WeatherPage));
            Routing.RegisterRoute("//home/weather/activity", typeof(ActivityDetailPage));


            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddTransient<StartPage>();
            builder.Services.AddTransient<WeatherPage>();
            builder.Services.AddTransient<ActivityDetailPage>();
            builder.Services.AddSingleton<IWeatherRepository, WeatherRepository>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}