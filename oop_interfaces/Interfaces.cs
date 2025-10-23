namespace oop_interfaces
{
    public interface IWeatherService
    {
        string GetCurrentWeather(string location);
    }

    public interface INotificationService
    {
        void SendNotification(string message);
    }
}