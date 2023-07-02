using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger) {
            _logger = logger;
        }
        [HttpGet]
        public String get()
        {
            _logger.LogInformation("My Log here.");
            return "Get methed here...";
        }
    }
}
