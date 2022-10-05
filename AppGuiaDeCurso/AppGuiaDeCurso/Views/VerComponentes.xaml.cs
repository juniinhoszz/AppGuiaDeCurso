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

            txtTitulo.Text = c.Nome;

            txtAtrRes.Text = c.AtribuicoesResponsabilidades;

            txtValAtitu.Text = c.ValoresAtitudes;

            txtcomp.Text = c.Competencias;

            txthab.Text = c.Habilidades;

            txtbasestec.Text = c.BasesTecnologicas;

            txtCargaHr.Text = c.CargaHoraria.ToString() + " horas.";
        }
    }
}