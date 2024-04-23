using Microsoft.AspNetCore.Mvc;
using Test.net8.Model;
using Test.net8.Service;

namespace Test.net8.Common.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<List<UserVo>> Get()
        {
           var userService = new UserService();
            var userList = await userService.Quer();
            return userList;
        }
    }
}
