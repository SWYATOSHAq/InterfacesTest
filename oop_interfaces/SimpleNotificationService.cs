namespace oop_interfaces
{
    class EmailNotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($" Отправка email: {message}");
        }
    }
    
    class SmsNotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($" Отправка SMS: {message}");
        }
    }
    
    class ConsoleNotificationService : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($" Уведомление в консоли: {message}");
        }
    }
}