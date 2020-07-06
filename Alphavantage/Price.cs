using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Alphavantage
{
    public static class Price
    {
        /// <summary>
        /// Get Exchnage Data
        /// </summary>
        /// <param name="FromCurrency">The currency you would like to get the exchange rate for. It can either be a physical currency or digital/crypto currency. For example: from_currency=USD or from_currency=BTC. </param>
        /// <param name="ToCurrency">The destination currency for the exchange rate. It can either be a physical currency or digital/crypto currency. For example: to_currency=USD or to_currency=BTC.</param>
        public static async Task<double> GetPriceAsync(string FromCurrency, string ToCurrency)
        {
            string API_KEY = "60GJ3J79HQJLF9HC";
            StringBuilder urlBuilder = new StringBuilder($"https://www.alphavantage.co/");
            urlBuilder.Append($"query?function=CURRENCY_EXCHANGE_RATE&from_currency={FromCurrency}&to_currency={ToCurrency}&apikey={API_KEY}");


            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(urlBuilder.ToString());
            var machine = JsonConvert.DeserializeObject<AlphaVentagePRICEData>(response);
            var _PRICE = machine.RealtimeCurrencyExchangeRate.The5ExchangeRate;
          
            
            return _PRICE;
        }
    }
}
