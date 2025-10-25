using Microsoft.Maui.Controls;
using System;
using AppWiglaTCC.Data;

namespace AppWiglaTCC.Views
{
    public partial class LoginPage : ContentPage
    {
        private UsuarioDatabase db = new UsuarioDatabase();

        public LoginPage()
        {
            InitializeComponent();
        }

        // Evento do Entry de senha (Completed)
        private void OnSenhaCompleted(object sender, EventArgs e)
        {
            Entrar();
        }

        // Evento do botão Entrar
        private void Entrar_Clicked(object sender, EventArgs e)
        {
            Entrar();
        }

        // Evento do botão Cadastrar-se
        private async void Cadastrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppWiglaTCC.Views.CadastroPage());
        }

        // Método de login
        private async void Entrar()
        {
            string email = EmailEntry.Text?.Trim(); 
            string senha = SenhaEntry.Text?.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                await DisplayAlert("Erro", "Preencha e-mail e senha.", "OK");
                return;
            }

            if (!db.ValidarLogin(email, senha))
            {
                await DisplayAlert("Erro", "E-mail ou senha incorretos.", "OK");
                return;
            }

            var usuario = db.ObterUsuarioPorEmail(email);
            await DisplayAlert("Sucesso", $"Bem-vindo, {usuario.Nome}!", "OK");

            await Navigation.PushAsync(new AppWiglaTCC.Views.MainPage());
        }
    }
}
