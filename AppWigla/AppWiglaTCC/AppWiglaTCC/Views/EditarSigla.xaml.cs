using AppWiglaTCC.Models;

namespace AppWiglaTCC.Views;

public partial class EditarSigla : ContentPage
{
    private Sigla siglaAtual;

    // Construtor que recebe a sigla selecionada
    public EditarSigla(Sigla sigla)
    {
        InitializeComponent();
        siglaAtual = sigla;
        BindingContext = sigla;

        // Preenche os campos com os dados da sigla
        txt_sigla.Text = sigla.Abreviacao;
        txt_significado.Text = sigla.Significado;
        txt_descricao.Text = sigla.Descricao;
        picker_categoria.SelectedItem = sigla.Categoria;
    }

    private async void Editar_Clicked(object sender, EventArgs e)
    {
        try
        {
            siglaAtual.Abreviacao = txt_sigla.Text;
            siglaAtual.Significado = txt_significado.Text;
            siglaAtual.Descricao = txt_descricao.Text;
            siglaAtual.Categoria = picker_categoria.SelectedItem?.ToString() ?? "";

            // Exemplo: await SiglaService.AtualizarSigla(siglaAtual);

            await DisplayAlert("Sucesso!", "Registro atualizado com sucesso!", "OK");
            await Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", $"Falha ao atualizar: {ex.Message}", "OK");
        }
    }

    private async void Voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
