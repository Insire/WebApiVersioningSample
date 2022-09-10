using ClassLibrary1;
using Microsoft.AspNetCore.Mvc.Testing;
using WebApplication1;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public async Task Should_Use_V1()
        {
            using var application = new WebApplicationFactory<Program>();

            var httpClient = application.CreateClient();

            var client = new Client(httpClient);

            var forecast = await client.V1.WeatherForecast.GetWeatherForecastAsync();
            Assert.NotNull(forecast);
            Assert.NotEmpty(forecast);
        }

        [Fact]
        public async Task Should_Use_V2()
        {
            using var application = new WebApplicationFactory<Program>();

            var httpClient = application.CreateClient();

            var client = new Client(httpClient);

            var forecast = await client.V2.WeatherForecast.GetWeatherForecast20Async();
            Assert.NotNull(forecast);
            Assert.NotEmpty(forecast);
        }

        [Fact]
        public async Task Should_Use_V21()
        {
            using var application = new WebApplicationFactory<Program>();

            var httpClient = application.CreateClient();

            var client = new Client(httpClient);

            var forecast = await client.V21.WeatherForecast.GetWeatherForecast21Async();
            Assert.NotNull(forecast);
            Assert.NotEmpty(forecast);
        }
    }
}
