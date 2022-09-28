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

            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Inicial)));
        }

        private void BtnInicial_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnPrimeiro_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnSegundo_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnTerceiro_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnVestibulinho_Clicked(object sender, EventArgs e)
        {

        }
    }
}
