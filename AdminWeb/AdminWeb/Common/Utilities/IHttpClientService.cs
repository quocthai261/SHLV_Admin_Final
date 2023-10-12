namespace AdminWeb.Common.Utilities
{
    public interface IHttpClientService
    {
        Task<(TResult, int)> Get<TResult>(string url);
        Task<(TResult, int)> PostJson<TResult>(string url, string postData);
        Task<T> DecomposeToken<T>(string token);
    }
}
