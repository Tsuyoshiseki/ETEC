using AppWiglaTCC.Models;

namespace AppWiglaTCC.Views;

public partial class EditarSigla : ContentPage
{
	public EditarSigla()
	{
		InitializeComponent();
	}

    public EditarSigla(Sigla sigla)
    {
        InitializeComponent();
        BindingContext = sigla;
    }

    private async void Editar_Clicked(object sender, EventArgs e)
    {
        try
        {
            Sigla sigla_anexado = BindingContext as Sigla;

            Sigla s = new Sigla
            {
                Abreviacao = txt_sigla.Text,
                Significado = txt_significado.Text,
                Descricao = txt_descricao.Text,
                Categoria = picker_categoria.SelectedItem?.ToString() ?? ""
            };

            await DisplayAlert("Sucesso!", "Resgistro atualizado", "OK");

            await Navigation.PopAsync();

        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
    private async void Voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}