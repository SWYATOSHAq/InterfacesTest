namespace oop_interfaces
{
    public class SimpleWeatherService : IWeatherService
    {
        public string GetCurrentWeather(string location)
        {
            return $"Погода в {location} 10°C, облачно";
        }
    }
}