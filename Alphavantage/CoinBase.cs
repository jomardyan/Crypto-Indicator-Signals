using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Markets
{
    public static class CoinBase
    {
        // htts://api.coinbase.com/v2/prices/:currency_pair/spot
        /// <summary>
        /// Get price for desired pair
        /// </summary>
        /// <param name="symbol">Flat Curency</param>
        /// <param name="currency">Crypto Curency</param>
        /// <returns></returns>
	    public static async Task<string> GetSpotDataAsync(string symbol, string currency)
        {
            HttpClient client = new HttpClient();
            string URL = $"https://api.coinbase.com/v2/prices/{symbol}-{currency}/spot";
            var response = await client.GetStringAsync(URL);
            RootObject data = JsonConvert.DeserializeObject<RootObject>(response);
            client.Dispose();
            return Math.Round(data.data.amount,2).ToString();
        }

        public static async Task<List<RootObject>> GetSpotDataAsync(List<string> symbol, string currency)
        {
            List<RootObject> MarketData = new List<RootObject>();

            foreach (var item in symbol)
            {
                HttpClient client = new HttpClient();
                string URL = $"https://api.coinbase.com/v2/prices/{item}-{currency}/spot";
                var response = await client.GetStringAsync(URL);
                RootObject data = JsonConvert.DeserializeObject<RootObject>(response);
                MarketData.Add(data);

            }
            return MarketData;
        }
    }

    public partial class SpotData
    {
        public string @base { get; set; }
        public string currency { get; set; }
        public double amount { get; set; }
    }

    public partial class RootObject
    {
        public SpotData data { get; set; }
    }
}