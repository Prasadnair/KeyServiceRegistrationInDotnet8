using KeyedServiceRegistration.Interfaces;

namespace KeyedServiceRegistration.Implementations
{
    public class EmailNotification : INotificationService
    {
        public async Task<string> NotifyAsync(string message)=> 
            await Task.FromResult($"Email Notification: {message}");
        
    }
}
