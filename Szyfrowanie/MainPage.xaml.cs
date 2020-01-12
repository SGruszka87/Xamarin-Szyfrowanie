using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Szyfrowanie
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();

            editKodowanie.IsEnabled = false;
        }

        private void btnKoduj_Clicked(object sender, EventArgs e)
        {
            var kodowanie = Kodowanie.RSAEncrypt(entryWprowadzCiagZnakow.Text);
            WyswietlDane(0, kodowanie);
        }

        private void btnRozkoduj_Clicked(object sender, EventArgs e)
        {
            var rozkodowanie = Kodowanie.RSADecrypt(entryWprowadzCiagZnakow.Text);
            WyswietlDane(1, rozkodowanie);
        }

        private void WyswietlDane(int rodzajOperacji, string szyfrowanie)
        {
            if (rodzajOperacji == 0)
            {
                DisplayAlert("Wykonano kodowanie wiadomości: ", "" + entryWprowadzCiagZnakow.Text,"OK");
                editKodowanie.IsEnabled = true;
                editKodowanie.Text = szyfrowanie;
            }
            if (rodzajOperacji == 1)
            {
                DisplayAlert("Wykonano rozkodowania wiadomości: ", "" + entryWprowadzCiagZnakow.Text, "OK");
                editKodowanie.IsEnabled = true;
                editKodowanie.Text = szyfrowanie;
            }
        }

    }
}
