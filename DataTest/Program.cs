using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alphavantage; 

namespace DataTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
           
           Console.WriteLine(await RSI.GetRsiAsync("BTCUSD", "60min", "60")); 

            Console.WriteLine(await Price.GetPriceAsync("BTC", "USD"));

            Console.ReadLine(); 

        }
    }
}
