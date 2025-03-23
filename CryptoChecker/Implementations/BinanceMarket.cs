using Binance.Net.Clients;
using Binance.Net.Objects.Models.Spot;
using CryptoChecker.Interfaces;

namespace CryptoChecker.Implementations
{
    public class BinanceMarket : IStockMarket<BinanceRestClient>
    {
        private BinanceRestClient _binanceRestClient;
        private IEnumerable<BinanceSymbol> _pairs;
        public async Task<decimal> GetCoursePairs(string baseAsset, string quoteAsset)
        {
            var client = GetClient();
            var pair = _pairs.FirstOrDefault(x => x.BaseAsset == baseAsset && x.QuoteAsset == quoteAsset);
            var tickerResult = await client.SpotApi.ExchangeData.GetTickerAsync(pair.Name);
            if (tickerResult.Data != null)
                return tickerResult.Data.LastPrice;
            return 0;
        }
        public BinanceRestClient GetClient()
        {
            if (_binanceRestClient == null)
                return new BinanceRestClient();
            return _binanceRestClient;
        }
        public async Task<IEnumerable<BinanceSymbol>> GetPairs() 
        {
            var client = GetClient();
            var tickets = await client.SpotApi.ExchangeData.GetExchangeInfoAsync();
            _pairs = tickets.Data.Symbols;
            return _pairs;
        }
    }
}
