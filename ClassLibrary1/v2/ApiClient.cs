namespace ClassLibrary1.v2
{
    public abstract class ApiClient
    {
        private const string api_version = "2.0";

        public virtual void PrepareRequest(HttpRequestMessage request)
        {
            request.Headers.TryAddWithoutValidation("api-version", api_version);
        }
    }
}
