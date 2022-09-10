namespace ClassLibrary1.v21
{
    public sealed class Client
    {
        public IWeatherForecastClient WeatherForecast { get; }

        public Client(HttpClient httpClient)
        {
            WeatherForecast = new WeatherForecastClient(httpClient);
        }
    }
}
