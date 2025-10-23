namespace oop_interfaces;

public class Program
{
    public static void Main(string[] args)
    {
        IWeatherService weatherService = new SimpleWeatherService();
        INotificationService notificationService = null;
        Console.WriteLine("Каким способом вы хотите получить уведомление?:");
        Console.WriteLine("1 - console");
        Console.WriteLine("2 - email");
        Console.WriteLine("3 - sms");
        int change = Convert.ToInt32(Console.ReadLine());
        switch (change)
        {
            case 1:
                notificationService = new ConsoleNotificationService(); break;
            case 2:
                notificationService = new EmailNotificationService(); break;
            case 3:
                notificationService = new SmsNotificationService(); break;
                
        }
        
        
        var alertService = new WeatherAlertService(weatherService, notificationService);
        
        alertService.SendWeatherAlert("Москва");
        
    }
}