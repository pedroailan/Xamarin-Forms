using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ListaFuncionarios.ItemsSource = GetFuncionarios();
        }

        private List<Grupo> GetFuncionarios()
        {
            return new List<Grupo>
            {
                new Grupo("Presidente", "CEO", "Presidente da Empresa")
                {
                    new Pessoa {Nome = "Ailan", IsObrigatorio = true, RankEficiencia = 8 },
                },

                new Grupo("Diretores", "Dir.", "Diretor da Empresa")
                {
                    new Pessoa {Nome = "Pedro", IsObrigatorio = false},
                    new Pessoa {Nome = "John", IsObrigatorio = true, RankEficiencia = 9 },
                },

                new Grupo("Gerentes", "Ger.", "Gerente da Empresa")
                {
                    new Pessoa {Nome = "Maria", IsObrigatorio = true, RankEficiencia = 6 },
                    new Pessoa {Nome = "Juliana", IsObrigatorio = true, RankEficiencia = 8 },
                },

                new Grupo("Funcionarios", "Ger.", "Funcionarios da Empresa")
                {
                    new Pessoa {Nome = "Maria", IsObrigatorio = false},
                    new Pessoa {Nome = "Juliana", IsObrigatorio = false},
                    new Pessoa {Nome = "Maria", IsObrigatorio = false},
                    new Pessoa {Nome = "Maria", IsObrigatorio = false},
                    new Pessoa {Nome = "Junior", IsObrigatorio = false},
                    new Pessoa {Nome = "Joao", IsObrigatorio = false},
                    new Pessoa {Nome = "Maria", IsObrigatorio = false},
                    new Pessoa {Nome = "Juliana", IsObrigatorio = false},
                    new Pessoa {Nome = "Maria", IsObrigatorio = false},
                    new Pessoa {Nome = "Maria", IsObrigatorio = false},
                    new Pessoa {Nome = "Junior", IsObrigatorio = false},
                    new Pessoa {Nome = "Joao"}
                },

            };
        }
        public class Pessoa
        {
            public string Nome { get; set; }
            public int RankEficiencia { get; set; }
            public bool IsObrigatorio { get; set; }
        }

        public class Grupo : List<Pessoa>
        {
            public string Titulo { get; set; }
            public string TituloCurto { get; set; }
            public string Descricao { get; set; }
            public Grupo(string titulo, string tituloCurto, string descricao)
            {
                Titulo = titulo;
                TituloCurto = tituloCurto;
                Descricao = descricao;
            }

        }
    }
}
