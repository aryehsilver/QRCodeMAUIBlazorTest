using ZXing.Net.Maui;

namespace QRCodeMAUIBlazorTest;

public partial class NewPage1 : ContentPage {
  public List<BarcodeResult> BarcodeResults { get; set; } = new();

  public NewPage1() {
    InitializeComponent();
    cameraBarcodeReaderView.Options = new BarcodeReaderOptions {
      Formats = BarcodeFormats.OneDimensional,
      AutoRotate = true,
      Multiple = true
    };
  }

  protected void BarcodesDetected(object sender, BarcodeDetectionEventArgs e) {
    BarcodeResults = e.Results.ToList();

    foreach (BarcodeResult barcode in e.Results) {
      Console.WriteLine($"Barcodes: {barcode.Format} -> {barcode.Value}");
    }
  }

  private void ReturnToBlazor_Clicked(object sender, EventArgs e) =>
    Navigation.PushModalAsync(new MainPage(BarcodeResults));
}