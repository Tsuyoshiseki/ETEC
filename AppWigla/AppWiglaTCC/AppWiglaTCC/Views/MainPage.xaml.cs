using System.Collections.ObjectModel;

namespace AppWiglaTCC
{
    public partial class MainPage : ContentPage
    {
        // Lista observável para ligar na CollectionView
        public ObservableCollection<Abreviacao> Abreviacoes { get; set; }
        public ObservableCollection<Abreviacao> Destaques { get; set; }

        public MainPage()
        {
            InitializeComponent();

            // Dados mockados (teste)
            Abreviacoes = new ObservableCollection<Abreviacao>
        {
            new Abreviacao { Sigla = "API", Descricao = "Application Programming Interface" },
            new Abreviacao { Sigla = "HTML", Descricao = "HyperText Markup Language" },
            new Abreviacao { Sigla = "CSS", Descricao = "Cascading Style Sheets" },
            new Abreviacao { Sigla = "SQL", Descricao = "Structured Query Language" },
            new Abreviacao { Sigla = "OOP", Descricao = "Object-Oriented Programming" }
        };

            Destaques = new ObservableCollection<Abreviacao>
        {
            new Abreviacao { Sigla = "AI", Descricao = "Artificial Intelligence" },
            new Abreviacao { Sigla = "IoT", Descricao = "Internet of Things" },
            new Abreviacao { Sigla = "DevOps", Descricao = "Development and Operations" }
        };

            // Liga dados nas listas
            abreviacoesCollection.ItemsSource = Abreviacoes;
            destaquesCollection.ItemsSource = Destaques;
        }

        // Evento da barra de busca
        private void OnSearchButtonPressed(object sender, EventArgs e)
        {
            var query = searchBar.Text?.ToLower() ?? "";

            var filtradas = Abreviacoes
                .Where(a => a.Sigla.ToLower().Contains(query) ||
                            a.Descricao.ToLower().Contains(query))
                .ToList();

            abreviacoesCollection.ItemsSource = filtradas;
        }
    }

    // Classe modelo de abreviação
    public class Abreviacao
    {
        public string Sigla { get; set; }
        public string Descricao { get; set; }
    }
}