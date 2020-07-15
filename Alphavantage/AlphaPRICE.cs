using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Markets
{
    public static class AlphaPRICE
    {
        /// <summary>
        /// Get Exchnage Data
        /// </summary>
        /// <param name="FromCurrency">The currency you would like to get the exchange rate for. It can either be a physical currency or digital/crypto currency. For example: from_currency=USD or from_currency=BTC. </param>
        /// <param name="ToCurrency">The destination currency for the exchange rate. It can either be a physical currency or digital/crypto currency. For example: to_currency=USD or to_currency=BTC.</param>
        public static async Task<string> GetPriceAsync(string FromCurrency, string ToCurrency)
        {
            string API_KEY = "60GJ3J79HQJLF9HC";
            StringBuilder urlBuilder = new StringBuilder($"https://www.alphavantage.co/");
            urlBuilder.Append($"query?function=CURRENCY_EXCHANGE_RATE&from_currency={FromCurrency}&to_currency={ToCurrency}&apikey={API_KEY}");

            HttpClient client = new HttpClient();
            System.TimeSpan timeSpan = new TimeSpan(0, 0, 60);
            client.Timeout = timeSpan;
            var response = await client.GetStringAsync(urlBuilder.ToString());
            var data = JsonConvert.DeserializeObject<AlphaVentagePRICEData>(response);
            var _PRICE = data.RealtimeCurrencyExchangeRate.The5ExchangeRate;
            client.Dispose();
            return _PRICE.ToString();
        }
    }
}