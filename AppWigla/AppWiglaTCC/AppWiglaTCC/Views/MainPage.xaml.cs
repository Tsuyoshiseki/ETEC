using AppWiglaTCC.Models;
using AppWiglaTCC.Data;

namespace AppWiglaTCC.Views
{
    public partial class MainPage : ContentPage
    {
        private SiglaDatabase db = new SiglaDatabase();

        public MainPage()
        {
            InitializeComponent();
            CarregarSiglas();
        }


        private async void SiglasCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Sigla siglaSelecionada)
            {
                await Navigation.PushAsync(new EditarSigla(siglaSelecionada));

                ((CollectionView)sender).SelectedItem = null;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CarregarSiglas();
        }

        private void CarregarSiglas()
        {
            try
            {
                var Sigla = db.BuscarSiglas("")
                               .OrderBy(s => s.Abreviacao)
                               .ToList();
                SiglasCollection.ItemsSource = Sigla;
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro", $"Erro ao carregar siglas: {ex.Message}", "OK");
            }
        }

        private void Procurar_Clicked(object sender, EventArgs e)
        {
            string termo = txtBusca.Text?.Trim() ?? "";

            try
            {
                List<Sigla> resultado;

                if (string.IsNullOrEmpty(termo))
                {
                    resultado = db.BuscarSiglas("").OrderBy(s => s.Abreviacao).ToList();
                }
                else
                {
                    resultado = db.BuscarSiglas("")
                                  .Where(s => s.Abreviacao.ToLower().Contains(termo.ToLower()))
                                  .OrderBy(s => s.Abreviacao)
                                  .ToList();
                }

                SiglasCollection.ItemsSource = resultado;

                if (resultado.Count == 0)
                    DisplayAlert("Aviso", "Nenhuma sigla encontrada.", "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Erro", $"Erro ao buscar siglas: {ex.Message}", "OK");
            }
        }


        private void Adicionar_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Views.AdicionarSigla());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}