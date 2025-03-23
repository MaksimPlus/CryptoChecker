using CryptoChecker.Interfaces;
using Kucoin.Net.Clients;

namespace CryptoChecker.Implementations
{
    public class KucoinMarket : IStockMarket<KucoinRestClient>
    {
        private KucoinRestClient _kucoinRestClient;
        public async Task<decimal> GetCoursePairs(string baseAsset, string quoteAsset)
        {
            var client = GetClient();
            var pairs = await client.SpotApi.ExchangeData.GetSymbolsAsync();
            var pair = pairs.Data.FirstOrDefault(x => x.BaseAsset == baseAsset && x.QuoteAsset == quoteAsset);
            if (pair != null)
            {
                var tickerResult = await client.SpotApi.ExchangeData.GetTickerAsync(pair.Name);
                if (tickerResult.Data != null && tickerResult.Data.LastPrice.HasValue)
                    return tickerResult.Data.LastPrice.Value;
            }
            return 0;
        }
        public KucoinRestClient GetClient()
        {
            if (_kucoinRestClient == null)
                return new KucoinRestClient();
            return _kucoinRestClient;
        }
    }
}
