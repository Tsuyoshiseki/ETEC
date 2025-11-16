using AppWiglaTCC.Data;
using AppWiglaTCC.Models;

namespace AppWiglaTCC.Views
{
    public partial class EditarSigla : ContentPage
    {
        private Sigla siglaSelecionada;

        public EditarSigla(Sigla sigla)
        {
            InitializeComponent();
            siglaSelecionada = sigla;

            txt_sigla.Text = sigla.Abreviacao;
            txt_significado.Text = sigla.Significado;
            txt_descricao.Text = sigla.Descricao;
            picker_categoria.SelectedItem = sigla.Categoria;
        }
        private async void Editar_Clicked(object sender, EventArgs e)
        {
            try
            {
                siglaSelecionada.Abreviacao = txt_sigla.Text;
                siglaSelecionada.Significado = txt_significado.Text;
                siglaSelecionada.Descricao = txt_descricao.Text;
                siglaSelecionada.Categoria = picker_categoria.SelectedItem?.ToString() ?? "";

                await DisplayAlert("Sucesso!", "Registro atualizado com sucesso!", "OK");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Erro", $"Falha ao atualizar: {ex.Message}", "OK");
            }
        }
        private async void Excluir_Clicked(object sender, EventArgs e)
        {
            bool confirmar = await DisplayAlert("Confirmação",
                $"Deseja realmente excluir a sigla \"{siglaSelecionada.Abreviacao}\"?",
                "Sim", "Não");

            if (confirmar)
            {
                var db = new SiglaDatabase();
                db.ExcluirSigla(siglaSelecionada.Id);

                await DisplayAlert("Sucesso", "Sigla excluída com sucesso!", "OK");

                // volta para a página principal
                await Navigation.PushAsync(new AppWiglaTCC.Views.MainPage());
            }
        }

        private async void Voltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
