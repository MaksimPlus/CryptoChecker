using Bitget.Net.Clients;
using CryptoChecker.Interfaces;

namespace CryptoChecker.Implementations
{
    public class BitgetMarket : IStockMarket<BitgetRestClient>
    {
        private BitgetRestClient _bitgetRestClient;
        public async Task<decimal> GetCoursePairs(string baseAsset, string quoteAsset)
        {
            var client = GetClient();
            var pairs = await client.SpotApi.ExchangeData.GetSymbolsAsync();
            var pair = pairs.Data.FirstOrDefault(x => x.BaseAsset == baseAsset && x.QuoteAsset == quoteAsset);
            if (pair != null)
            {
                var tickerResult = await client.SpotApi.ExchangeData.GetTickerAsync(pair.Id);
                if (tickerResult.Data != null)
                    return tickerResult.Data.ClosePrice;
            }
            return 0;
            
        }
        public BitgetRestClient GetClient()
        {
            if (_bitgetRestClient == null)
                return new BitgetRestClient();
            return _bitgetRestClient;
        }
    }
}
