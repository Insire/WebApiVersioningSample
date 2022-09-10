namespace ClassLibrary1.v1
{
    public partial class WeatherForecastClient
    {
        partial void PrepareRequest(System.Net.Http.HttpClient client, System.Net.Http.HttpRequestMessage request, string url)
        {
            PrepareRequest(request);
        }

        partial void UpdateJsonSerializerSettings(System.Text.Json.JsonSerializerOptions settings)
        {
            settings.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
        }
    }
}
