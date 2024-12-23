
using System.Net.Http.Json;
using System.Text.Json;

namespace BALZORWEBCORE
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<WeatherForecast>> GetWeatherForecastAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://backendperucors.runasp.net/WeatherForecast");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            Console.WriteLine(await response.Content.ReadAsStringAsync());

            return await response.Content.ReadFromJsonAsync<List<WeatherForecast>>();
        }
    }
}
