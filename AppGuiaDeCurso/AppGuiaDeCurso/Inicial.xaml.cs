using AppGuiaDeCurso.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGuiaDeCurso
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicial : ContentPage
    {
        public Inicial()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromResource("AppGuiaDeCurso.img.etec.jpeg");

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