using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using AppGuiaDeCurso.Views;

namespace AppGuiaDeCurso
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            img.Source = ImageSource.FromResource("AppGuiaDeCurso.img.logo.png");

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicial))) { BarBackgroundColor = Color.FromHex("#AB0209") };


        }

        private async void BtnInicial_Clicked(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicial))) { BarBackgroundColor = Color.FromHex("#AB0209") };
                IsPresented = false;
            }
            catch(Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void BtnPrimeiro_Clicked(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ComponentesPrimeiro))) { BarBackgroundColor = Color.FromHex("#AB0209") };
            ;
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void BtnSegundo_Clicked(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ComponentesSegundo))) { BarBackgroundColor = Color.FromHex("#AB0209") };
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void BtnTerceiro_Clicked(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ComponentesTerceiro))) { BarBackgroundColor = Color.FromHex("#AB0209") };
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void BtnVestibulinho_Clicked(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Vestibulinho))) { BarBackgroundColor = Color.FromHex("#AB0209") };
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void BtnContato_Clicked(object sender, EventArgs e)
        {
            try
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Contato))) { BarBackgroundColor = Color.FromHex("#AB0209") };
                IsPresented = false;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }
    }
}
