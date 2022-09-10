namespace ClassLibrary1.v21
{
    public abstract class ApiClient
    {
        private const string api_version = "2.1";

        public virtual void PrepareRequest(HttpRequestMessage request)
        {
            request.Headers.TryAddWithoutValidation("api-version", api_version);
        }
    }
}
