using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace Alphavantage
{
    public static class RSI
    {
        


        public static async Task<string> GetRsiAsync(string symbol1, string interval1, string period1)
        {
            //API KEY FROM alphavantage.co
            string API_KEY = "60GJ3J79HQJLF9HC";

            StringBuilder urlBuilder = new StringBuilder();
            urlBuilder.Append($"https://www.alphavantage.co/");
            urlBuilder.Append($"query?function=RSI&symbol={symbol1}&interval={interval1}&time_period={period1}&series_type=open&apikey={API_KEY}");

            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(urlBuilder.ToString());

            var machine = JsonConvert.DeserializeObject<AlphavantageData>(response);
            var _RSI = machine.TechnicalAnalysisRsi.Last().Value.Rsi;
            return Math.Round(_RSI, 2).ToString();
        }

    }
}
