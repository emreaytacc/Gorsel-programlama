using Microsoft.Maui.Controls;

namespace Emre.Sayfalar
{
    public partial class RenkSecici : ContentPage
    {
        public RenkSecici()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int red = (int)sliderRed.Value;
            int green = (int)sliderGreen.Value;
            int blue = (int)sliderBlue.Value;

            string hex = Color.FromRgb(red, green, blue).ToHex();

            boxRenk.Color = Color.FromRgb(red, green, blue);
            lblHex.Text = "Hex Kodu: " + hex;
        }

        private void RandomRenk_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();
            int red = random.Next(0, 256);
            int green = random.Next(0, 256);
            int blue = random.Next(0, 256);

            sliderRed.Value = red;
            sliderGreen.Value = green;
            sliderBlue.Value = blue;
        }
         private void CopyHex_Clicked(object sender, EventArgs e)
        {
            string hex = lblHex.Text.Replace("Renk Kodu: ", "");
            Clipboard.SetTextAsync(hex);
            DisplayAlert("Kopyalandı", "Renk kodu panoya kopyalandı.", "Tamam");
        }
    }
}

