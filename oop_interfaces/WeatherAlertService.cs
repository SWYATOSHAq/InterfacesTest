namespace oop_interfaces;

public class WeatherAlertService
{

    private readonly IWeatherService _weatherService;
    private readonly INotificationService _notificationService;

    public WeatherAlertService(IWeatherService weatherService, INotificationService notificationService)
    {
        _weatherService = weatherService;
        _notificationService = notificationService;
    }

    public void SendWeatherAlert(string location)
    {
        string weather = _weatherService.GetCurrentWeather(location);
        _notificationService.SendNotification(weather);
    }

}
    
    