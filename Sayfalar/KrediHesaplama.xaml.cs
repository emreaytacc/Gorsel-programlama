using Microsoft.Maui.Controls;
using System;
using System.Globalization;

namespace Emre.Sayfalar
{
    public partial class KrediHesaplama : ContentPage
    {
        public KrediHesaplama()
        {
            InitializeComponent();
        }

        private void Hesapla_Clicked(object sender, EventArgs e)
        {
            double krediTutari = Convert.ToDouble(txtKrediTutari.Text);
            double faizOrani = Convert.ToDouble(txtFaizOrani.Text);
            int vade = Convert.ToInt32(txtVade.Text);

            double bsmv = 0;
            double kkdf = 0;

            switch (pickerKrediTuru.SelectedIndex)
            {
                case 0: 
                    bsmv = 0.10;  
                    kkdf = 0.15;  
                    break;
                case 1: 
                    break;
                case 2:   
                    bsmv = 0.05;  
                    kkdf = 0.15;  
                    break;
                case 3:   
                    bsmv = 0.05; 
                    break;
            }

            double brutFaiz = ((faizOrani + (faizOrani * bsmv) + (faizOrani * kkdf)) / 100);

            double taksit = ((Math.Pow(1 + brutFaiz, vade) * brutFaiz) / (Math.Pow(1 + brutFaiz, vade) - 1)) * krediTutari;

            double toplam = taksit * vade;

             lblAylikTaksit.Text = "Aylık Taksit: " + taksit.ToString("C", new CultureInfo("tr-TR"));
             lblToplamOdeme.Text = "Toplam Ödeme: " + toplam.ToString("C", new CultureInfo("tr-TR"));
             lblToplamFaiz.Text = "Toplam Faiz: " + ((toplam - krediTutari)).ToString("C", new CultureInfo("tr-TR"));

        }
    }
}
