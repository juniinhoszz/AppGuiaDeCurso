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
    public partial class ComponentesPrimeiro : ContentPage
    {
        public ComponentesPrimeiro()
        {
            InitializeComponent();

            img.Source = ImageSource.FromResource("AppGuiaDeCurso.img.logo.png");
        }

        private void BtnProgWeb_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnAnalise_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnDesign_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnInf_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnTecAlg_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnBanco_Clicked(object sender, EventArgs e)
        {

        }
    }
}