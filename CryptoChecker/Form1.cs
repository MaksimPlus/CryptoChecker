using CryptoChecker.Implementations;
using CryptoChecker.Models;

namespace CryptoChecker
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private BinanceMarket _binanceMarket = new BinanceMarket();
        private BybitMarket _bybitMarket = new BybitMarket();
        private KucoinMarket _kucoinMarket = new KucoinMarket();
        private BitgetMarket _bitgetMarket = new BitgetMarket();
        public Form1()
        {
            InitializeComponent();
            FillPairs();
            FillValues();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += OnTimedEvent;
            timer.Start();
        }
        public async void FillValues()
        {
            var selectedItem = comboBox1.SelectedItem as MarketPair;
            if (selectedItem != null)
            {
                var binancePair = await _binanceMarket.GetCoursePairs(selectedItem.BaseAsset, selectedItem.QuoteAsset);
                tbBinance.Text = binancePair.ToString();

                var bybitPair = await _bybitMarket.GetCoursePairs(selectedItem.BaseAsset, selectedItem.QuoteAsset);
                tbBybit.Text = bybitPair.ToString();

                var kucoinPair = await _kucoinMarket.GetCoursePairs(selectedItem.BaseAsset, selectedItem.QuoteAsset);
                tbKucoin.Text = kucoinPair.ToString();

                var bitgetPair = await _bitgetMarket.GetCoursePairs(selectedItem.BaseAsset, selectedItem.QuoteAsset);
                tbBitget.Text = bitgetPair.ToString();
            }
        }
        private async void FillPairs()
        {
            var pairs = await _binanceMarket.GetPairs();

            var marketPairs = pairs.Select(x => new MarketPair
            {
                Symbol = x.Name,
                BaseAsset = x.BaseAsset,
                QuoteAsset = x.QuoteAsset
            }).ToList();

            comboBox1.DataSource = marketPairs;
            comboBox1.DisplayMember = "Symbol";
            comboBox1.ValueMember = "Key";
        }
        private async void OnTimedEvent(object sender, EventArgs e)
        {
            FillValues();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            timer.Stop();
            FillValues();
            timer.Start();
        }
    }
}
