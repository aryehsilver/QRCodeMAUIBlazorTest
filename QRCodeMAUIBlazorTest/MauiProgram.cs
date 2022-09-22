using QRCodeMAUIBlazorTest.Data;
using ZXing.Net.Maui;

namespace QRCodeMAUIBlazorTest;

public static class MauiProgram {
  public static MauiApp CreateMauiApp() {
    MauiAppBuilder builder = MauiApp.CreateBuilder();
    builder
      .UseMauiApp<App>()
      .UseBarcodeReader()
      .ConfigureFonts(fonts => {
        fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
      });

    builder.Services.AddMauiBlazorWebView();
#if DEBUG
    builder.Services.AddBlazorWebViewDeveloperTools();
#endif

    builder.Services.AddSingleton<WeatherForecastService>();

    return builder.Build();
  }
}
