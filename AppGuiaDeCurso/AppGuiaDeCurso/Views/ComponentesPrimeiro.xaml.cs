using AppGuiaDeCurso.Models;
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
        }

        private async void BtnProgWeb_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Programação Web I",

                    AtribuicoesResponsabilidades = "Desenvolver Sites para Web",

                    ValoresAtitudes = "• Incentivar a criatividade. • Estimular a organização. • Fortalecer a persistencia e o interesse na resolução de situação-problema",

                    Competencias = "Implementar páginas para a Internet",

                    Habilidades = "Desenvolver páginas para internet, utilizando linguagem de marcação de texto • Utilizar linguagem de script para Web • Construir folhas de estilo",

                    BasesTecnologicas = "Conceitos de desenvolvimento para a Web: Introdução e terminologia • Apresentação do editor / IDE, navegadores e ferramentas do desenvolvedor embutidas nos navegadores • Linguagem de Marcação para a Web(HTML) • Documento HTML mínimo, tags, atributos e conteúdo",

                    CargaHoraria = 200,
                    
                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch(Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void BtnAnalise_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Análise e Projeto de Sistemas",

                    AtribuicoesResponsabilidades = "Desenvolver Sites para Web",

                    ValoresAtitudes = "• Incentivar a criatividade. • Estimular a organização. • Fortalecer a persistencia e o interesse na resolução de situação-problema",

                    Competencias = "",

                    Habilidades = "",

                    BasesTecnologicas = "",

                    CargaHoraria = 200,

                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void BtnDesign_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Design Digital",

                    AtribuicoesResponsabilidades = "Desenvolver Sites para Web",

                    ValoresAtitudes = "• Incentivar a criatividade. • Estimular a organização. • Fortalecer a persistencia e o interesse na resolução de situação-problema",

                    Competencias = "",

                    Habilidades = "",

                    BasesTecnologicas = "",

                    CargaHoraria = 200,

                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void BtnInf_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Fundamentos da Informática",

                    AtribuicoesResponsabilidades = "Desenvolver Sites para Web",

                    ValoresAtitudes = "• Incentivar a criatividade. • Estimular a organização. • Fortalecer a persistencia e o interesse na resolução de situação-problema",

                    Competencias = "",

                    Habilidades = "",

                    BasesTecnologicas = "",

                    CargaHoraria = 200,

                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void BtnTecAlg_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Técnicas de Programação e Algoritmos",

                    AtribuicoesResponsabilidades = "Desenvolver Sites para Web",

                    ValoresAtitudes = "• Incentivar a criatividade. • Estimular a organização. • Fortalecer a persistencia e o interesse na resolução de situação-problema",

                    Competencias = "",

                    Habilidades = "",

                    BasesTecnologicas = "",

                    CargaHoraria = 200,

                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void BtnBanco_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Banco de Dados I",

                    AtribuicoesResponsabilidades = "Desenvolver Sites para Web",

                    ValoresAtitudes = "• Incentivar a criatividade. • Estimular a organização. • Fortalecer a persistencia e o interesse na resolução de situação-problema",

                    Competencias = "",

                    Habilidades = "",

                    BasesTecnologicas = "",

                    CargaHoraria = 200,

                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }
    }
}