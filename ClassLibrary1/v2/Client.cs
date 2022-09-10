using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.v2
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
