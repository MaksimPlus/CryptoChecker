namespace CryptoChecker.Models
{
    public class MarketPair
    {
        public string Symbol { get; set; }
        public string BaseAsset { get; set; }
        public string QuoteAsset { get; set; }

        public string Key => $"{BaseAsset}-{QuoteAsset}";
    }
}
