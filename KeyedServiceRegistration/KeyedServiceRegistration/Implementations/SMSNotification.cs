using KeyedServiceRegistration.Interfaces;

namespace KeyedServiceRegistration.Implementations
{
    public class SMSNotification : INotificationService
    {
        public async Task<string> NotifyAsync(string message)=> 
            await Task.FromResult($"SMS Notification: {message}");
            
    }
}
