using DesafioApi02.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DesafioApi02.Service
{
    public static class JurosCompostosService
    {
        static JurosCompostos JurosCompostos { get; set; }
        static JurosCompostosViewModel JurosCompostosViewModel { get; set; }

        static JurosCompostosService()
        {
        }

        public static async Task<JurosCompostosViewModel> GetJurosCompostos(decimal valorInicial, int meses)
        {
            string url = "https://desafioapi01.azurewebsites.net/taxaJuros";
            
            using (HttpClient cliente = new HttpClient())
            {
                var response = cliente.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<dynamic>(json);
                    var jsonResponse = values["valorTaxa"];

                    JurosCompostos = new JurosCompostos
                    {
                        ValorInicial = valorInicial,
                        Meses = meses,
                        TaxaJuros = jsonResponse
                    };

                }
            }

            decimal rawValue = JurosCompostos.ValorInicial * (decimal)Math.Pow(1 + JurosCompostos.TaxaJuros, JurosCompostos.Meses);

            return JurosCompostosViewModel = new JurosCompostosViewModel
            {
                ValorFinal = String.Format("{0:0.00}", rawValue)
            };
        }
    }
}
