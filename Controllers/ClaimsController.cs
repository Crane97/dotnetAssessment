using Microsoft.AspNetCore.Mvc;

namespace FinalAssessmentDotNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClaimsController : ControllerBase
    {


        private readonly ILogger<WeatherForecastController> _logger;

        public ClaimsController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "claims/all")]
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

        [HttpGet(Name = "claims/get/{id}")]
        public IEnumerable<WeatherForecast> Get(int id)
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost(Name = "add")]
        public async Task Post(Claims claims)
        {
            _context.Add(claims);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut(Name = "update")]
        public async Task Put(Claims claims)
        {
            _context.Add(claims);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}