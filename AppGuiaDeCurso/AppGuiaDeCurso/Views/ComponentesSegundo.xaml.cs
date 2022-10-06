using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AppGuiaDeCurso.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGuiaDeCurso.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComponentesSegundo : ContentPage
    {
        public ComponentesSegundo()
        {
            InitializeComponent();
        }

        private async void BtnProgWeb_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Programação Web II",

                    AtribuicoesResponsabilidades = "Desenvolver Sites para Web",

                    ValoresAtitudes = "• Incentivar a criatividade. • Estimular a organização. • Fortalecer a persistencia e o interesse na resolução de situação-problema",

                    Competencias = "Implementar páginas para a Internet",

                    Habilidades = "Desenvolver páginas para internet, utilizando linguagem de marcação de texto • Utilizar linguagem de script para Web • Construir folhas de estilo",

                    BasesTecnologicas = "Conceitos de desenvolvimento para a Web: Introdução e terminologia • Apresentação do editor / IDE, navegadores e ferramentas do desenvolvedor embutidas nos navegadores • Linguagem de Marcação para a Web(HTML) • Documento HTML mínimo, tags, atributos e conteúdo",

                    CargaHoraria = 80,

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
                    Nome = "Banco de Dados II",

                    AtribuicoesResponsabilidades = "Modelar banco de dados. ",

                    ValoresAtitudes = "Estimular a organização • estimular o interesse na resolução de situações-problema • Promover ações que considerem o respeito às normas estabelecidas.",

                    Competencias = "Desenvolver modelo de banco de dados.",

                    Habilidades = " Levantar as necessidades de informações do sistema • Normalizar tabelas de banco de dados • Associar as tabelas para construção de banco de dados • Aplicar linguagem SQL na construção de tabelas.",

                    BasesTecnologicas = "Estrutura de banco de dados • Modelo conceitual • Dicionário de dados ",

                    CargaHoraria = 80,

                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void BtnDesSis_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Desenvolvimento de Sistemas",

                    AtribuicoesResponsabilidades = "Desenvolver Aplicativos para Computadores" +
                    "",

                    ValoresAtitudes = "Incentivar a criatividade. • Estimular a organização. • Fortalecer a persistencia e o interesse na resolução de situação-problema",

                    Competencias = "Implementar Aplicativos para Computadores",

                    Habilidades = "Desenvolver e implantar sistemas de tecnologia da informação, dimensionando requisitos e funcionalidades dos sistemas; Administrar e estabelecer padrões para ambiente de TI, elaborar planejamento e execução de testes dos sistemas",

                    BasesTecnologicas = "Conhecer as estruturas, os comandos e as sintaxes de uma determinada linguagem de programação. Refletir sobre as instruções lógicas que serão aplicadas e, também, construir e testar algoritmos.",

                    CargaHoraria = 80,

                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void BtnEmbar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Sistemas Embarcados",

                    AtribuicoesResponsabilidades = "Desenvolver projetos com componentes eletrônicos(Hardware e Software).",

                    ValoresAtitudes = "• Incentivar a criatividade. • Estimular a organização. • Fortalecer a persistencia e o interesse na resolução de situação-problema",

                    Competencias = "Desenvolver projetos com componentes eletrônicos.",

                    Habilidades = "Desenvolver produtos de forma multidisciplinar: software, hardware, lógica programável, firmware",

                    BasesTecnologicas = "Componentes eletrônicos, micro e nano que usam movimento, acelerômetro e giroscópio.",

                    CargaHoraria = 80,

                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void BtnMobile_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Programação de Aplicativos Mobile I",

                    AtribuicoesResponsabilidades = "Desenvolver Aplicativos para dispositivos móveis",

                    ValoresAtitudes = "Incentivar a criatividade. • Estimular a organização. • Fortalecer a persistencia e o interesse na resolução de situação-problema",

                    Competencias = "Implementar aplicativos móveis",

                    Habilidades = "Desenvolvimento de interfaces de programação de aplicativos (APIs) para oferecer suporte à funcionalidade móvel; Implementação de novidades e futuros desenvolvimentos de aplicativos já existentes; Garantir a coerência entre o lado funcional e o lado técnico; ",

                    BasesTecnologicas = "Envolve conhecimentos referentes a experiência do usuário (UX); Programação da tela; Otimização do aplicativo (quanto mais rápido, melhor)",

                    CargaHoraria = 80,

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