using Alphavantage;
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
            BTC_PRICE_VALUE.Text = await Price.GetPriceAsync("BTC", "USD");
            ETH_PRICE_VALUE.Text = await Price.GetPriceAsync("ETH", "USD");
            LTC_PRICE_VALUE.Text = await Price.GetPriceAsync("LTC", "USD");
            XRP_PRICE_VALUE.Text = await Price.GetPriceAsync("XRP", "USD");
            LINK_PRICE_VALUE.Text = await Price.GetPriceAsync("LINK", "USD");
            BCH_PRICE_VALUE.Text = await Price.GetPriceAsync("BCH", "USD");

            //BTC_RSI_VALUE.Text = await RSI.GetRsiAsync("BTCUSD", "60min", "60");
        }
    }
}