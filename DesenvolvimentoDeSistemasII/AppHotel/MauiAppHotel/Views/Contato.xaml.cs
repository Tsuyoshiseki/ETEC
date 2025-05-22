namespace MauiAppHotel.Views;

public partial class Contato : ContentPage
{
    public Contato()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private async void OnMapaClicked(object sender, EventArgs e)
    {
        var location = new Location(-23.33019, -46.37599);
        var options = new MapLaunchOptions { Name = "Hotel Paraíso" };

        try
        {
            await Map.Default.OpenAsync(location, options);
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", "Não foi possível abrir o mapa: " + ex.Message, "OK");
        }

    }
}
