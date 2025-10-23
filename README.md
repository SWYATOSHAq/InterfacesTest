Interface.cs: создание контрактов(интерфейсов) IWeatherService и INotificationService
SimpleNotificationService: реализация сервиса уведомлений(там как раз и показана работа интерфейсов)
SimpleWeatherService: реализация сервиса погоды
WeatherAlertService: реализация системы оповещения(принимает данные погоды из сервиса погоды и данные о способе отправки сообщения)
Program.cs демонстрация работоспособности сервиса
