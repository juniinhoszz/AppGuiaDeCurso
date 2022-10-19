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
    public partial class ComponentesTerceiro : ContentPage
    {
        public ComponentesTerceiro()
        {
            InitializeComponent();
        }

        private async void BtnProgWeb_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Programação Web III",

                    AtribuicoesResponsabilidades = "Desenvolver Sites para Web",

                    ValoresAtitudes = "• Incentivar a criatividade. • Estimular a organização. • Fortalecer a persistencia e o interesse na resolução de situação-problema",

                    Competencias = "Implementar páginas para a Internet",

                    Habilidades = "Desenvolver páginas para internet, utilizando linguagem de marcação e programação.",

                    BasesTecnologicas = "Utilização de ambiente de desenvolvimento integrado para a construção de sistemas web, através de conjunto de tecnologias e paradigmas • Utilização de navegadores web para testes automatizados",

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
                    Nome = "Programação de Aplicativos Mobile II",

                    AtribuicoesResponsabilidades = "Documentar, construir e manter sistemas de informação para plataformas móveis.",

                    ValoresAtitudes = "Incentivar a criatividade. • Estimular a organização. • Fortalecer a persistencia e o interesse na resolução de situação-problema",

                    Competencias = "Implementar aplicativos móveis",

                    Habilidades = "Desenvolvimento de interfaces de programação de aplicativos (APIs) para oferecer suporte à funcionalidade móvel; Implementação de novidades e futuros desenvolvimentos de aplicativos já existentes • Garantir a coerência entre o lado funcional e o lado técnico  Utilização de ambiente de desenvolvimento integrado para a construção de softwares mobile. ",

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

        private async void BtnProt_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Internet, Protocolos e Segurança de Sistemas da Informação",

                    AtribuicoesResponsabilidades = "Implementar rotinas de segurança da informação.",

                    ValoresAtitudes = "Estimular atitudes respeitosas. • Incentivar comportamentos éticos. • Desenvolver a criticidade.",

                    Competencias = "Desenvolver rotinas de segurança da informação.",

                    Habilidades = "Criação de documentos e planilhas para documentação do planejamento do trabalho de conclusão de curso • Criação de pesquisas em formulários eletrônicos.",

                    BasesTecnologicas = "Medidas de proteção adotadas para proteger a integridade das tecnologias de informação como sistemas, software, hardware, redes e suas informações",

                    CargaHoraria = 80,

                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void BtnTCC_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Desenvolvimento do Trabalho de Conclusão de Curso (TCC) em Desenvolvimento de Sistemas",

                    AtribuicoesResponsabilidades = "Planejar e desenvolver projetos de sistemas computacionais.",

                    ValoresAtitudes = "Planejar ações mais eficazes no desenvolvimento de sistemas. • Demonstrar comprometimento com equipe e o trabalho.",

                    Competencias = "Criação de documentos e planilhas para documentação do trabalho de conclusão de curso.",

                    Habilidades = "Criação de documentos e planilhas para documentação dos planos e avanços.",

                    BasesTecnologicas = "Avanços tecnológicos; • Ciclo de vida do setor; • Demandas e tendências futuras da área profissional; • Identificação de lacunas (demandas não atendidas plenamente) e de situações-problema do setor.",

                    CargaHoraria = 80,

                };

                await Navigation.PushAsync(new VerComponentes(c));
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro!", ex.Message, "OK");
            }
        }

        private async void BtnQualid_Clicked(object sender, EventArgs e)
        {
            try
            {
                var c = new Componentes
                {
                    Nome = "Qualidade e Teste de Software",

                    AtribuicoesResponsabilidades = "Testar softwares para melhoria da qualidade de sistemas. • Elaborar registros e planilhas de acompanhamento e controle das atividades.",

                    ValoresAtitudes = "Responsabilizar-se pela produção, utilização e divulgação de informações. • Estimular a proatividade. • Desenvolver criticidade. • Incentivar comportamentos éticos",

                    Competencias = "Utilização de softwares de apoio para o teste de sistemas e sua documentação.",

                    Habilidades = "Criação de documentos e planilhas para documentação dos planos e casos de testes.",

                    BasesTecnologicas = "Visa checar o nível de qualidade de algum Software",

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