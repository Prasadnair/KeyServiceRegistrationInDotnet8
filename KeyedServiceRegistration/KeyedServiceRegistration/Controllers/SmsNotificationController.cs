using KeyedServiceRegistration.Enums;
using KeyedServiceRegistration.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KeyedServiceRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmsNotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;
        public SmsNotificationController(IServiceProvider serviceProvider)=>
        
            _notificationService=serviceProvider.GetRequiredKeyedService<INotificationService>(Keys.SMS);

        // GET: api/<NotificationController>
        [HttpGet("sms")]
        public IActionResult Get()
        {
            return Ok(_notificationService.NotifyAsync("Keyed Service Registration"));
        }

    }
}
