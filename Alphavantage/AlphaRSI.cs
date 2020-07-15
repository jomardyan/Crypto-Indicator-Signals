using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Markets
{
    public static class AlphaRSI
    {
        public static async Task<string> GetRsiAsync(string symbol1, string interval1, string period1)
        {
            Thread.Sleep(500);
            System.Threading.Thread.Sleep(500);
            //API KEY FROM alphavantage.co
            string API_KEY = "60GJ3J79HQJLF9HC";
            TimeSpan timeSpan = new TimeSpan(0, 0, 10);
            StringBuilder urlBuilder = new StringBuilder();
            urlBuilder.Append($"https://www.alphavantage.co/");
            urlBuilder.Append($"query?function=RSI&symbol={symbol1}&interval={interval1}&time_period={period1}&series_type=open&apikey={API_KEY}");

            HttpClient client = new HttpClient();
            client.Timeout = timeSpan;
            try
            {
                var response = await client.GetStringAsync(urlBuilder.ToString());
                var machine = JsonConvert.DeserializeObject<AlphavantageData>(response);
                var _RSI = machine.TechnicalAnalysisRsi.Last().Value.Rsi;
                return Math.Round(_RSI, 2).ToString();

            }
            catch (WebException e)
            {
                Debug.WriteLine(e.Message);
             
            }
            finally
            {
                Debug.WriteLine("GetRSIAsync code finished"); 
            }

            return ""; 
        }
    }
}