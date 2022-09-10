namespace ClassLibrary1
{
    public sealed class Client
    {
        public Client(HttpClient httpClient)
        {
            V1 = new v1.Client(httpClient);
            V2 = new v2.Client(httpClient);
            V21 = new v21.Client(httpClient);
        }

        public v1.Client V1 { get; }

        public v2.Client V2 { get; }

        public v21.Client V21 { get; }
    }
}
