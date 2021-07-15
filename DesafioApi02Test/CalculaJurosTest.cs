using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesafioApi02.Service;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System;
using DesafioApi02.Model;

namespace DesafioApi02Test
{
    [TestClass]
    public class CalculaJurosTest
    {
        public async Task<double> GetTaxaJuros()
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

                    return jsonResponse;
                }
                else
                {
                    throw new System.TimeoutException();
                }
            }

        }

        [TestMethod]
        public void IntegridadeCalculaJuros()
        {
            double valorInicial = 100;
            int meses = 5;
            var taxaJuros = GetTaxaJuros();

            double valorFinal = valorInicial * Math.Pow((1 + Convert.ToDouble(taxaJuros.Result)), meses);

            var expected = new JurosCompostosViewModel { ValorFinal = String.Format("{0:0.00}", valorFinal) };
            var actual = JurosCompostosService.GetJurosCompostos((decimal)valorInicial, meses);

            Assert.AreEqual(expected.ValorFinal, actual.Result.ValorFinal);
        }
    }
}
