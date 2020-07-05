using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Alphavantage
{

    public partial class AlphavantageData
    {
        [JsonProperty("Meta Data")]
        public MetaData MetaData { get; set; }

        [JsonProperty("Technical Analysis: RSI")]
        public Dictionary<string, TechnicalAnalysisRsi> TechnicalAnalysisRsi { get; set; }
    }

    public partial class MetaData
    {
        [JsonProperty("1: Symbol")]
        public string The1Symbol { get; set; }

        [JsonProperty("2: Indicator")]
        public string The2Indicator { get; set; }

        [JsonProperty("3: Last Refreshed")]
        public DateTimeOffset The3LastRefreshed { get; set; }

        [JsonProperty("4: Interval")]
        public string The4Interval { get; set; }

        [JsonProperty("5: Time Period")]
        public long The5TimePeriod { get; set; }

        [JsonProperty("6: Series Type")]
        public string The6SeriesType { get; set; }

        [JsonProperty("7: Time Zone")]
        public string The7TimeZone { get; set; }
    }

    public partial class TechnicalAnalysisRsi
    {
        [JsonProperty("RSI")]
        public string Rsi { get; set; }
    }

    public partial class AlphavantageData
    {
        public static AlphavantageData FromJson(string json) => JsonConvert.DeserializeObject<AlphavantageData>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this AlphavantageData self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
    


    }

