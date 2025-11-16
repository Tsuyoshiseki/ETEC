using AppWiglaTCC.Models;
using AppWiglaTCC.Data;

namespace AppWiglaTCC.Views;

public partial class MainPage : ContentPage
{
    private SiglaDatabase db = new SiglaDatabase();
    private List<Sigla> todasSiglas;
    private string categoriaSelecionada = "Todas";

    public MainPage()
    {
        InitializeComponent();
        CarregarSiglas();
        picker_categoria.SelectedIndex = 0;

    }

    private void CarregarSiglas()
    {
        try
        {
            todasSiglas = db.BuscarSiglas("").OrderBy(s => s.Abreviacao).ToList();
            FiltrarSiglas();
        }
        catch (Exception ex)
        {
            DisplayAlert("Erro", $"Erro ao carregar siglas: {ex.Message}", "OK");
        }
    }

    private void FiltrarSiglas()
    {
        string termo = txtBusca.Text?.Trim().ToLower() ?? "";

        var filtradas = todasSiglas
            .Where(s =>
                (categoriaSelecionada == "Todas" || s.Categoria == categoriaSelecionada) &&
                (string.IsNullOrEmpty(termo) || s.Abreviacao.ToLower().Contains(termo)))
            .OrderBy(s => s.Abreviacao)
            .ToList();

        SiglasCollection.ItemsSource = filtradas;

        if (filtradas.Count == 0)
            DisplayAlert("Aviso", "Nenhuma sigla encontrada.", "OK");
    }

    private void Procurar_Clicked(object sender, EventArgs e)
    {
        AtualizarTitulo();
        FiltrarSiglas();
    }

    private void Picker_categoria_SelectedIndexChanged(object sender, EventArgs e)
    {
        categoriaSelecionada = picker_categoria.SelectedItem?.ToString() ?? "Todas";
        AtualizarTitulo();
        FiltrarSiglas();
    }

    private async void SiglasCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection != null && e.CurrentSelection.Count > 0)
        {
            var siglaSelecionada = e.CurrentSelection[0] as Sigla;
            if (siglaSelecionada != null)
            {
                await Navigation.PushAsync(new DetalheSiglaPage(siglaSelecionada));
            }

            ((CollectionView)sender).SelectedItem = null;
        }
    }

    private void Adicionar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new AdicionarSigla());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private async void OnSairClicked(object sender, EventArgs e)
    {
        // Volta para LoginPage
        Application.Current.MainPage = new NavigationPage(new LoginPage());
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        CarregarSiglas();
    }

    private void AtualizarTitulo()
    {
        string categoria = picker_categoria.SelectedItem?.ToString() ?? "Todas";
        string termo = txtBusca.Text?.Trim();

        if (!string.IsNullOrWhiteSpace(termo) && categoria != "Todas")
        {
            lblUltimas.Text = $"Resultados para \"{termo}\" - Categoria: {categoria}";
        }
        else if (!string.IsNullOrWhiteSpace(termo))
        {
            lblUltimas.Text = $"Resultados para \"{termo}\"";
        }
        else if (categoria != "Todas")
        {
            lblUltimas.Text = $"Categoria: {categoria}";
        }
        else
        {
            lblUltimas.Text = "Últimas adicionadas";
        }
    }

}
