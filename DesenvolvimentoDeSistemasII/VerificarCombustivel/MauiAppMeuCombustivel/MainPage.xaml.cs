namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                string marca = txt_marca.Text;
                string modelo = txt_modelo.Text;

                if (string.IsNullOrEmpty(marca) || string.IsNullOrEmpty(modelo))
                {
                    DisplayAlert("Erro", "Por favor, insira a marca e o modelo do veículo.", "OK");
                    return;
                }
                
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";

                if (etanol <= (gasolina * 0.7)) {

                    msg = $"O etanol está compensando no seu {marca} {modelo}.";

                }else {

                    msg = $"A gasolina está compensando no seu {marca} {modelo}.";
                }

                DisplayAlert("Calculado", msg, "OK");

            } catch(Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }

        } // Fecha método
    } //Fecha Class
} // Fecha namespace
