using KeyedServiceRegistration.Enums;
using KeyedServiceRegistration.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KeyedServiceRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailNotificationController : ControllerBase
    {
        // GET: api/<EmailNotificationController>
        [HttpGet("email")]
        public IActionResult Get([FromKeyedServices(Keys.Email)] INotificationService notificationService)
        =>
            Ok(notificationService.NotifyAsync("Keyed Service Registration"));
        
    }
}
