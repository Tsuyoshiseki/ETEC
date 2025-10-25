using AppWiglaTCC.Models;

namespace AppWiglaTCC.Views;

public partial class DetalheSiglaPage : ContentPage
{
    public DetalheSiglaPage(Sigla sigla)
    {
        InitializeComponent();
        BindingContext = sigla; // Define a sigla selecionada como contexto
    }

    private async void Voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void Editar_Clicked(object sender, EventArgs e)
    {
        // Supondo que o BindingContext tenha a sigla atual
        var sigla = (Sigla)BindingContext;

        // Navega para a página de edição, passando a sigla selecionada
        await Navigation.PushAsync(new EditarSigla(sigla));
    }
}
