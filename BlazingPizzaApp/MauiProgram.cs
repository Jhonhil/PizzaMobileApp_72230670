using BlazingPizzaApp.Data;
using Microsoft.Extensions.Logging;

namespace BlazingPizzaApp
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
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddScoped<OrderState>();
            // Tambahkan atau ganti pendaftaran HttpClient di MauiProgram.cs
            builder.Services.AddScoped(sp => new HttpClient
            {
                BaseAddress = new Uri("http://localhost:7219/") // <--- Cek & sesuaikan port ini dengan port BlazingPizzaApp.API Anda
            });

            builder.Services.AddHttpClient<IPizzaSpecials, PizzaSpecialsServices>(client =>
            {
                var baseUrl = DeviceInfo.Platform == DevicePlatform.Android
                    ? "http://10.0.2.2:7219/"
                    : "http://localhost:7219/";

                client.BaseAddress = new Uri(baseUrl);
            });

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}