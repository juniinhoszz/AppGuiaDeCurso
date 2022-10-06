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

                    CargaHoraria = 80,
                    
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

                    AtribuicoesResponsabilidades = "Elaborar projetos de sistema de informação.",

                    ValoresAtitudes = "Incentivar a criatividade • Estimular a organização • Estimular o interesse na resolução de situações-problema.",

                    Competencias = "Modelar projeto de sistemas • Selecionar modelos para o desenvolvimento de sistemas.",

                    Habilidades = "Coletar requisitos de usuários e sistemas • Utilizar métodos de abordagem, coleta de dados e procedimentos de pesquisa  • Aplicar modelo Cascata no desenvolvimento desistemas  • Aplicar modelos Ágeis a projetos de software.",

                    BasesTecnologicas = "Ciclo de vida de um sistema • Estudo de viabilidade; • Especificação de requisitos; • Concepções do modelo Cascata; • Concepções dos modelos Ágeis • Introdução à análise e projeto orientado a objetos",

                    CargaHoraria = 80,

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

                    AtribuicoesResponsabilidades = "Desenvolver elementos gráficos para aplicativos e sites.",

                    ValoresAtitudes = "Incentivar a criatividade • Respeitar as manifestações culturais de outros povos • Estimular o interesse na resolução de situações-problema.",

                    Competencias = "Desenvolver interfaces visuais para aplicativos e sites.",

                    Habilidades = "Manipular ou construir elementos visuais para aplicativos e sites.",

                    BasesTecnologicas = "Softwares para edição e tratamento de imagens estáticas e em movimento • Teoria das cores • Círculo cromático; • Monocromia e cores neutras;",

                    CargaHoraria = 80,

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

                    AtribuicoesResponsabilidades = "Operar sistemas computacionais.",

                    ValoresAtitudes = "Desenvolver a criticidade • Incentivar comportamentos éticos • Promover ações que considerem o respeito às normas estabelecidas",

                    Competencias = "Articular conhecimentos de sistemas computacionais • Distinguir sistemas computacionais.",

                    Habilidades = "Distinguir arquiteturas de sistemas de hardware e software • Executar comandos em interface de linha de comando • Utilizar sistemas computacionais.",

                    BasesTecnologicas = "Evolução da Informática; • Representação binária de informações; • Unidades de medida de dados; • Hardware; • Software; • Redes de computadores, internet; • Software / hardware livre e proprietário; • Virtualização; • Computação na nuvem.",

                    CargaHoraria = 80,
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

                    AtribuicoesResponsabilidades = "Realizar versionamento no desenvolvimento de programas. Utilizar algoritmos em linguagem de programação, por meio de ambientes de desenvolvimento de acordo com as necessidades.",

                    ValoresAtitudes = "Incentivar atitudes de autonomia • Incentivar comportamentos éticos • Estimular o interesse na resolução de situações-problema",

                    Competencias = "Implementar algoritmos de programação • Elaborar sistemas, aplicando princípios e paradigmas de programação • Elaborar sistemas, aplicando princípios e paradigmas de programação.",

                    Habilidades = " Elaborar algoritmos • Codificar programas, utilizando técnica de programação estruturada • Depurar e versionar programas, utilizando ambiente de desenvolvimento integrado.",

                    BasesTecnologicas = "Construção de fluxograma • Princípios de programação • Linguagens de programação e códigos fonte,objeto e executável; • Teste de mesa.",

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
                    Nome = "Banco de Dados I",

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
    }
}