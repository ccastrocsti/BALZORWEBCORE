namespace BALZORWEBCORE
{
    public interface IApiService
    {

        Task<List<WeatherForecast>> GetWeatherForecastAsync();
    }
}
