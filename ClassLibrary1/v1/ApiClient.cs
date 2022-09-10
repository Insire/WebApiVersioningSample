namespace ClassLibrary1.v1
{
    public abstract class ApiClient
    {
        private const string api_version = "1.0";

        public virtual void PrepareRequest(HttpRequestMessage request)
        {
            request.Headers.TryAddWithoutValidation("api-version", api_version);
        }
    }
}
