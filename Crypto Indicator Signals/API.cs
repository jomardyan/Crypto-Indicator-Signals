using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Indicator_Signals
{
    class API
    {
        public int state { get; set; }
        #region HTTP GLOBAL ERRORS
        const string HTTP_403 = "WAF Limit (Web Application Firewall) has been violated";
        const string HTTP_429 = "Breaking a request rate limit";
        const string HTTP_418 = "IP Address has been banned";
        const string HTTP_4XX = "";
        readonly string HHTP_5XX = "";
        #endregion

        readonly string BASE_URL = "https://api.binance.com"; 
        public API()
        {

        }
    }
}
