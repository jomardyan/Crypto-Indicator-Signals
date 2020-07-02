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
        string HTTP_403 = "WAF Limit (Web Application Firewall) has been violated";
        string HTTP_429 = "Breaking a request rate limit";
        string HTTP_418 = "IP Address has been banned";
        string HTTP_4XX = "";
        string HHTP_5XX = ""; 
        #endregion

        string BASE_URL = "https://api.binance.com"; 
        public API()
        {

        }
    }
}
