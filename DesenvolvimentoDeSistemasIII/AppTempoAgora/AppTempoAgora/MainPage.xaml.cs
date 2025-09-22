﻿using AppTempoAgora.Services;
using System.Threading.Tasks;
using AppTempoAgora.Models;
using AppTempoAgora.Services;

namespace AppTempoAgora
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txt_cidade.Text))
                {
                    Tempo? t = await DataService.GetPrevisao(txt_cidade.Text);

                    if (t != null)
                    {
                        string dados_previsao = "";

                        dados_previsao = $"Latitude: {t.lat} \n" +
                                         $"Longitude: {t.lon} \n" +
                                         $"Nascer do Sol: {t.sunrise} \n" +
                                         $"Por do Sol: {t.sunset} \n" +
                                         $"Temp Máx: {t.temp_max} \n" +
                                         $"Temp Min: {t.temp_min} \n" +
                                         $"Descrição do clima: {t.description} \n" +
                                         $"Velocidade do vento: {t.speed} \n" +
                                         $"Visibilidade: {t.visibility} \n"; ;


                        lbl_res.Text = dados_previsao;

                    } else
                    {
                        lbl_res.Text = "Sem dados de Previsão";
                    }

                } else 
                {
                    await DisplayAlert("Aviso", "Digite o nome de uma cidade.", "OK");
                }

            } 
            catch (Exception ex) 
            {

                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }

}
