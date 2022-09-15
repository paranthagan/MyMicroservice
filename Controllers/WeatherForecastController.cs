using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace MyMicroservice.Controllers
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
        [Route("getStudents")]
        [HttpGet(Name = "GetStudents")]
        public List<Student> GetStudents()
        {
            List<Student> lstStudent = new List<Student> {
                new Student { Name = "Paran", Age = 45, StudentId = "654321" } ,
                new Student  { Name = "Viji", Age = 37, StudentId = "123456" }
            };

            return lstStudent;

        }
        [Route("Weather")]
    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

}
}

