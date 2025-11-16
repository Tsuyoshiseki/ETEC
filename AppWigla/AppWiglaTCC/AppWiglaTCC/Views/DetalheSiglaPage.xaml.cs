using AppWiglaTCC.Models;

namespace AppWiglaTCC.Views;

public partial class DetalheSiglaPage : ContentPage
{
    public DetalheSiglaPage(Sigla sigla)
    {
        InitializeComponent();
        BindingContext = sigla;
    }

    private async void Voltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void Editar_Clicked(object sender, EventArgs e)
    {
        var sigla = (Sigla)BindingContext;

        await Navigation.PushAsync(new EditarSigla(sigla));
    }
}
