namespace oop_interfaces;

public class Program
{
    public static void Main(string[] args)
    {
        IWeatherService _weatherService = new SimpleWeatherService();
        INotificationService _notificationService = new ConsoleNotificationService();
        
        var alertService = new WeatherAlertService(_weatherService, _notificationService);
        
        alertService.SendWeatherAlert("Москва");
        
    }
}