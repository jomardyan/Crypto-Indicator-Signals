using Markets;
using System.Threading;
using System.Windows;

namespace Crypto_Indicator_Signals
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //BTC_RSI.Background = Brushes.Black;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BTC_PRICE_VALUE.Text = ReturnString(await CoinBase.GetSpotDataAsync("BTC", "USD"));
            ETH_PRICE_VALUE.Text = ReturnString(await CoinBase.GetSpotDataAsync("ETH", "USD"));
            LTC_PRICE_VALUE.Text = ReturnString(await CoinBase.GetSpotDataAsync("LTC", "USD"));
            XRP_PRICE_VALUE.Text = ReturnString(await CoinBase.GetSpotDataAsync("XRP", "USD"));
            LINK_PRICE_VALUE.Text = ReturnString(await CoinBase.GetSpotDataAsync("LINK", "USD"));
            BCH_PRICE_VALUE.Text = ReturnString(await CoinBase.GetSpotDataAsync("BCH", "USD"));

            try
            {
                BTC_RSI_VALUE.Text = ReturnString(await AlphaRSI.GetRsiAsync("BTCUSD", "daily", "14"));
                ETH_RSI_VALUE.Text = ReturnString(await AlphaRSI.GetRsiAsync("ETHUSD", "daily", "14"));
                LTC_RSI_VALUE.Text = ReturnString(await AlphaRSI.GetRsiAsync("LTCUSD", "daily", "14"));
                Thread.Sleep(200);
                XRP_RSI_VALUE.Text = ReturnString(await AlphaRSI.GetRsiAsync("XRPUSD", "daily", "14"));
                LINK_RSI_VALUE.Text = ReturnString(await AlphaRSI.GetRsiAsync("LINKUSD", "daily", "14"));
                BCH_RSI_VALUE.Text = ReturnString(await AlphaRSI.GetRsiAsync("BCHUSD", "daily", "14"));
            }
            catch (System.Exception)
            {

                
            }
            
        }

        public static string ReturnString(string x)
        {
            try
            {
                if (x == null)
                {
                    return "";
                }
            }
            catch (System.Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
            
            return x;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window_Loaded(sender, e);
        }
    }
}