using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms.OpenWhatsApp;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGuiaDeCurso.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contato : ContentPage
    {
        public Contato()
        {
            InitializeComponent();
        }

        private void BtnTel_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:01936560052"));
        }

        private async void BtnEmail_Clicked(object sender, EventArgs e)
        {
            try
            {
                var address = "e070dir@cps.sp.gov.br";
                Device.OpenUri(new Uri($"mailto:{address}"));
            }
            catch(Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Chat.Open("+5514996794615", "Olá, Desejo fazer o curso de DS");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", "WhatsApp não encontrado, entre em contato pelo numero +55 14 99679-4615", "OK");
            }
        }
    }
}