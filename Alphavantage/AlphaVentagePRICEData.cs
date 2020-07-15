using Newtonsoft.Json;
using System;

namespace Markets
{
    public partial class AlphaVentagePRICEData
    {
        [JsonProperty("Realtime Currency Exchange Rate")]
        public RealtimeCurrencyExchangeRate RealtimeCurrencyExchangeRate { get; set; }
    }

    public partial class RealtimeCurrencyExchangeRate
    {
        [JsonProperty("1. From_Currency Code")]
        public string The1FromCurrencyCode { get; set; }

        [JsonProperty("2. From_Currency Name")]
        public string The2FromCurrencyName { get; set; }

        [JsonProperty("3. To_Currency Code")]
        public string The3ToCurrencyCode { get; set; }

        [JsonProperty("4. To_Currency Name")]
        public string The4ToCurrencyName { get; set; }

        [JsonProperty("5. Exchange Rate")]
        public double The5ExchangeRate { get; set; }

        [JsonProperty("6. Last Refreshed")]
        public DateTimeOffset The6LastRefreshed { get; set; }

        [JsonProperty("7. Time Zone")]
        public string The7TimeZone { get; set; }

        [JsonProperty("8. Bid Price")]
        public string The8BidPrice { get; set; }

        [JsonProperty("9. Ask Price")]
        public string The9AskPrice { get; set; }
    }
}