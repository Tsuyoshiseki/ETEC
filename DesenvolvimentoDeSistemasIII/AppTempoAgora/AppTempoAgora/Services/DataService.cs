using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using AppTempoAgora.Models;
using Newtonsoft.Json.Linq;

namespace AppTempoAgora.Services
{
    public class DataService
    {
        public static async Task<Tempo?> GetPrevisao(string cidade)
        {
            Tempo? t = null;

            string chave = "334e5fe63cd7e6852ecc32ea1e21227e";

            string url = $"https://api.openweathermap.org/data/2.5/weather?" +
                         $"q={cidade}&units=metric&appid={chave}&lang=pt_br";

            try
            {        
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage resp = await client.GetAsync(url);

                    if (resp.IsSuccessStatusCode)
                    {
                        string json = await resp.Content.ReadAsStringAsync();

                        var rascunho = JObject.Parse(json);

                        DateTime time = new();
                        long sunriseUnix = (long)rascunho["sys"]["sunrise"];
                        long sunsetUnix = (long)rascunho["sys"]["sunset"];
                        
                        DateTime sunrise = DateTimeOffset.FromUnixTimeSeconds(sunriseUnix).ToLocalTime().DateTime;
                        DateTime sunset = DateTimeOffset.FromUnixTimeSeconds(sunsetUnix).ToLocalTime().DateTime;

                        t = new()
                        {
                            lat = (double)rascunho["coord"]["lat"],
                            lon = (double)rascunho["coord"]["lon"],
                            description = (string)rascunho["weather"][0]["description"],
                            main = (string)rascunho["weather"][0]["main"],
                            temp_min = (double)rascunho["main"]["temp_min"],
                            temp_max = (double)rascunho["main"]["temp_max"],
                            speed = (double)rascunho["wind"]["speed"],
                            visibility = (int)rascunho["visibility"],
                            sunrise = sunrise.ToString("dd/MM/yyyy HH:mm:ss"),
                            sunset = sunset.ToString("dd/MM/yyyy HH:mm:ss"),
                        };
                    }
                    else if (resp.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        throw new Exception("Cidade não encontrada. Verifique o nome e tente novamente.");
                    }
                    else
                    {
                        throw new Exception($"Erro na requisição: {resp.StatusCode}");
                    }
                }
            }
            catch (HttpRequestException)
            {
                throw new Exception("Sem conexão com a internet. Verifique sua rede.");
            }
            catch (Exception)
            {
                throw; 
            }

            return t;
        }
    }
}