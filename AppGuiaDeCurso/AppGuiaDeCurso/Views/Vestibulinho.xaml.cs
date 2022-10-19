using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGuiaDeCurso.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vestibulinho : ContentPage
    {
        public Vestibulinho()
        {
            InitializeComponent();
        }

        private void Btnsite_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.vestibulinhoetec.com.br/home/"));
            
        }

        private async void BtnContato_Clicked(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Contato());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }
    }
}