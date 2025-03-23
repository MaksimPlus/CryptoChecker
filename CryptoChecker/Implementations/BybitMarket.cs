using Bybit.Net.Clients;
using CryptoChecker.Interfaces;

namespace CryptoChecker.Implementations
{
    public class BybitMarket : IStockMarket<BybitRestClient>
    {
        private BybitRestClient _bybitRestClient;
        public async Task<decimal> GetCoursePairs(string baseAsset, string quoteAsset)
        {
            var client = GetClient();
            var pairs = await client.V5Api.ExchangeData.GetSpotSymbolsAsync();
            var pair = pairs.Data.List.FirstOrDefault(x => x.BaseAsset == baseAsset && x.QuoteAsset == quoteAsset);
            if (pair != null)
            {
                var tickerResult = await client.V5Api.ExchangeData.GetSpotTickersAsync(pair.Name);
                if (tickerResult.Data != null)
                    return tickerResult.Data.List.First().LastPrice;
            }
            return 0;
        }
        public BybitRestClient GetClient()
        {
            if (_bybitRestClient == null)
                return new BybitRestClient();
            return _bybitRestClient;
        }
    }
}
