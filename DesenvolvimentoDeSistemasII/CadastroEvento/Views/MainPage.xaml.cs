using CadastroEvento.Models;
using CadastroEvento.Views;


namespace CadastroEvento.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new Evento();
    }

    private async void OnCadastrarClicked(object sender, EventArgs e)
    {
        try
        {
            var evento = (Evento)BindingContext;
            await Navigation.PushAsync(new ResumoPage(evento)
            {
                BindingContext = evento
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", ex.Message, "OK");
        }
    }
}