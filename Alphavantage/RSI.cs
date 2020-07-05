using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Alphavantage
{
    public static class RSI
    {
        public static void GetRsi()
        {
            string jsonData = new WebClient().DownloadString("https://www.alphavantage.co/query?function=RSI&symbol=BTCUSD&interval=daily&time_period=24&series_type=open&apikey=60GJ3J79HQJLF9HC&fbclid=IwAR1DK3LGmMMmTWtboCw0vDpCJh2n64QLr5ewCpwVoU3_TLRBIBn2F_ZZ6TM");
            var machine = JsonConvert.DeserializeObject<AlphavantageData>(jsonData);


            Console.WriteLine(machine.TechnicalAnalysisRsi.Last().Key + ": " + machine.TechnicalAnalysisRsi.Last().Value.Rsi);

            #region debug
            //Console.WriteLine($"SYmbol: {machine.MetaData.The1Symbol}");
            //Console.WriteLine($"SYmbol: {machine.MetaData.The2Indicator}");
            //Console.WriteLine($"SYmbol: {machine.MetaData.The3LastRefreshed}");
            //Console.WriteLine($"SYmbol: {machine.MetaData.The4Interval}");
            //Console.WriteLine($"SYmbol: {machine.MetaData.The5TimePeriod}");
            //Console.WriteLine($"SYmbol: {machine.MetaData.The6SeriesType}");
            //Console.WriteLine($"SYmbol: {machine.MetaData.The7TimeZone}");
            #endregion
            Console.ReadLine();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="symbol1">For Example BTCUSD</param>
        /// <param name="interval1">The following values are supported: 1min, 5min, 15min, 30min, 60min, daily, weekly, monthly</param>
        /// <param name="period1">Positive integers are accepted (e.g., time_period=60, time_period=200)</param>
        public static void GetRsi(string symbol1, string interval1, string period1)
        {
            //API KEY FROM alphavantage.co
            string API_KEY = "60GJ3J79HQJLF9HC";
            
            StringBuilder urlBuilder = new StringBuilder();
            urlBuilder.Append($"https://www.alphavantage.co/");
            urlBuilder.Append($"query?function=RSI&symbol={symbol1}&interval={interval1}&time_period={period1}&series_type=open&apikey={API_KEY}"); 
            
        }

    }
}
