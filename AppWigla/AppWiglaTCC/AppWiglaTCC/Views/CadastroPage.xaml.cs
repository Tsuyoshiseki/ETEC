namespace AppWiglaTCC.Views;
using AppWiglaTCC.Data;


public partial class CadastroPage : ContentPage
{
    public CadastroPage()
    {
        InitializeComponent();
    }

    private readonly UsuarioDatabase db = new UsuarioDatabase();

    private async void OnCadastrarClicked(object sender, EventArgs e)
    {
        var usuario = new Models.Usuario
        {
            Nome = nomeEntry.Text,
            Email = emailEntry.Text,
            Senha = senhaEntry.Text
        };

        bool sucesso = db.InserirUsuario(usuario);
        if (!sucesso)
        {
            await DisplayAlert("Erro", "E-mail j� cadastrado.", "OK");
            return;
        }

        await DisplayAlert("Sucesso", $"Usu�rio {usuario.Nome} cadastrado!", "OK");
        await Navigation.PopAsync();
    }
}