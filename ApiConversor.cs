using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace ConversorC
{
    internal class ApiConversor
    {

        private static readonly string url = "https://api.bcb.gov.br/dados/serie/bcdata.sgs.10813/dados/ultimos/1?formato=json";

        // Método para obter a cotação do dólar
        public async Task<decimal> ObterCotacaoDolarAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    // Ler o conteúdo da resposta
                    string result = await response.Content.ReadAsStringAsync();

                    // Parsear o JSON recebido para obter o valor da cotação do dólar
                    JArray jsonArray = JArray.Parse(result);

                    // Remover separadores de milhares, se houver, e garantir a conversão correta
                    string valorCotacao = jsonArray[0]["valor"].ToString();

                    // Usar NumberStyles para ignorar separadores de milhares e garantir que o valor seja tratado como decimal
                    decimal cotacaoDolar = decimal.Parse(valorCotacao, NumberStyles.Number, CultureInfo.InvariantCulture);

                    return cotacaoDolar;
                }
                else
                {
                    throw new Exception("Erro ao obter a cotação do dólar.");
                }
            }
        }
    }
}
