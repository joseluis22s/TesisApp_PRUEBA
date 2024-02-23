using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using TesisApp.DataBase.Repositories;

namespace TesisApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            }).UseMauiCommunityToolkit();
#if DEBUG
            builder.Logging.AddDebug();

            builder.Services.AddSingleton<UsuarioDatabase>();
#endif
            return builder.Build();
        }
    }
}