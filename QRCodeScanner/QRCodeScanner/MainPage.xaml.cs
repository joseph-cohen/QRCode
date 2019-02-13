using System;
using Xamarin.Forms;

namespace QRCodeScanner
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("aaba");



            var scanner = new ZXing.Mobile.MobileBarcodeScanner();

            var result = await scanner.Scan();

            if (result != null)
                Console.WriteLine("Scanned Barcode: " + result.Text);
                txtBarcode.Text = result.Text;
        }
    }
}