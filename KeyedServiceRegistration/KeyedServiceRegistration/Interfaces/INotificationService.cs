namespace KeyedServiceRegistration.Interfaces
{
    public interface INotificationService
    {
      Task<string>  NotifyAsync(string message);
    }
}
