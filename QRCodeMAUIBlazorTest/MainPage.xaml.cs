using ZXing.Net.Maui;

namespace QRCodeMAUIBlazorTest;

public partial class MainPage : ContentPage {
  public MainPage(List<BarcodeResult> barcodeResults = null) {
    InitializeComponent();
    rootComponent.Parameters = new Dictionary<string, object> {
      { "BarcodeResults", barcodeResults }
    };
  }
}
