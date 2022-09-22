using ZXing.Net.Maui;

namespace QRCodeMAUIBlazorTest;

public partial class NewPage1 : ContentPage {
  public NewPage1() {
    InitializeComponent();
    cameraBarcodeReaderView.Options = new BarcodeReaderOptions {
      Formats = BarcodeFormats.OneDimensional,
      AutoRotate = true,
      Multiple = true
    };
  }

  protected void BarcodesDetected(object sender, BarcodeDetectionEventArgs e) {
    foreach (BarcodeResult barcode in e.Results)
      Console.WriteLine($"Barcodes: {barcode.Format} -> {barcode.Value}");
  }
}