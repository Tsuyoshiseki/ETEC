namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Zerar_Clicked(object sender, EventArgs e)
        {
            Zerar();
        }

        // Alterna o botão entre "X" e "O"
        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.IsEnabled = false;

            if (vez == "X") {
                btn.Text = "X";
                vez = "O";

            }else {
                btn.Text = "O";
                vez = "X";
            }

            VerificarVencedor("X");
            VerificarVencedor("O");

            //caso haja empate
            if (TabuleiroCheio())
            {
                DisplayAlert("Empate!", "O jogo deu velha.", "OK");
                Zerar();
            }
        }

        //Verifica todas as opções de ganhar
        private bool VerificarVencedor(string jogador)
        {
            if ((btn10.Text == jogador && btn11.Text == jogador && btn12.Text == jogador) ||
                (btn20.Text == jogador && btn21.Text == jogador && btn22.Text == jogador) ||
                (btn30.Text == jogador && btn31.Text == jogador && btn32.Text == jogador) ||

                (btn10.Text == jogador && btn20.Text == jogador && btn30.Text == jogador) ||
                (btn11.Text == jogador && btn21.Text == jogador && btn31.Text == jogador) ||
                (btn12.Text == jogador && btn22.Text == jogador && btn32.Text == jogador) ||

                (btn10.Text == jogador && btn21.Text == jogador && btn32.Text == jogador) ||
                (btn12.Text == jogador && btn21.Text == jogador && btn30.Text == jogador))
            {
                DisplayAlert("Parabéns!", $"{jogador} ganhou!", "OK");
                Zerar();
                return true;
            }

            return false;
        }

        //Verifica se estão todos preenchidos
        private bool TabuleiroCheio()
        {
            return btn10.Text != "" && btn11.Text != "" && btn12.Text != "" &&
                   btn20.Text != "" && btn21.Text != "" && btn22.Text != "" &&
                   btn30.Text != "" && btn31.Text != "" && btn32.Text != "";
        }

        //Função de zerar o jogo, função do reset tb
        void Zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";

            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";

            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;

            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;

            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

            vez = "X";
        }
    }
}
