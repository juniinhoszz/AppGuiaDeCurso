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
    public partial class VerComponentes : ContentPage
    {
        public VerComponentes(Models.Componentes c)
        {
            InitializeComponent();

            BindingContext = c;

            txtCargaHr.Text = txtCargaHr.Text + " horas-aula.";
        }
    }
}