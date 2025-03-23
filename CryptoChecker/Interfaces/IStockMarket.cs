namespace CryptoChecker.Interfaces
{
    public interface IStockMarket<T> where T : class
    {
        T GetClient();
        Task<decimal> GetCoursePairs(string baseAsset, string quoteAsset);
    }
}
