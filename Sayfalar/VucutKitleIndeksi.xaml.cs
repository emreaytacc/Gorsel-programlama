using Microsoft.Maui.Controls;

namespace Emre.Sayfalar
{
    public partial class VucutKitleIndeksi : ContentPage
    {
        public VucutKitleIndeksi()
        {
            InitializeComponent();
        }
        private void Hesapla_Clicked(object sender, EventArgs e)
{
    if (!string.IsNullOrEmpty(txtBoy.Text) && !string.IsNullOrEmpty(txtKilo.Text))
    {
        double boy = Convert.ToDouble(txtBoy.Text);
        double kilo = Convert.ToDouble(txtKilo.Text);

        if (boy <= 0 || kilo <= 0)
        {
            lblSonuc.Text = "Boy ve kilo değerleri pozitif olmalıdır!";
            return;
        }

        double vki = kilo / (boy * boy);

        string sonuc = "Vücut Kitle İndeksi: " + vki.ToString("F2");

        if (vki < 16)
            sonuc += " (Ileri duzeyde zayif)";
        else if (vki < 16.99)
            sonuc += " (Orta Duzeyde Zayif)";
        else if (vki < 18.49)
            sonuc += " (Hafif Duzeyde Zayif)";
        else if (vki < 24.9)
            sonuc += " (Normal Kilolu)";
        else if (vki < 29.9)
            sonuc += " (Hafif Sisman / Fazla Kilolu)";
        else if (vki < 34.99)
            sonuc += " (1. Derecede Obez)";
        else if (vki < 39.99)
            sonuc += " (2. Derecede Obez)";
        else
            sonuc += " (3. Derecede Obez / Morbid Obez)";

        lblSonuc.Text = sonuc;
    }
    else
    {
        lblSonuc.Text = "Lütfen boy ve kilo değerlerini giriniz!";
    }
}

            }
}