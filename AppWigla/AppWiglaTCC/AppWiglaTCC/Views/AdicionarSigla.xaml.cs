using AppWiglaTCC.Models;
using AppWiglaTCC.Data;


namespace AppWiglaTCC.Views;

public partial class AdicionarSigla : ContentPage
{
    private SiglaDatabase db = new SiglaDatabase();

    public AdicionarSigla()
    {
        InitializeComponent();
    }

    private async void Adicionar_Clicked(object sender, EventArgs e)
    {
        try
        {
            var sigla = new Sigla
            {
                Abreviacao = txt_sigla.Text,
                Significado = txt_significado.Text,
                Descricao = txt_descricao.Text,
                Categoria = picker_categoria.SelectedItem?.ToString() ?? ""
            };

            db.InserirSigla(sigla);
            await DisplayAlert("Sucesso", "Sigla cadastrada!", "OK");

            await Navigation.PopAsync();

        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", ex.Message, "OK");
        }
    }

    private async void Voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}