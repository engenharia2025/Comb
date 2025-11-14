using Microsoft.Extensions.Logging;
using System.Runtime.Versioning;

namespace Comb
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            // Adiciona suporte apenas para Windows
#if WINDOWS
            builder.Logging.AddDebug();
#endif
#endif

            return builder.Build();
        }
    }
}