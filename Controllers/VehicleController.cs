using Microsoft.AspNetCore.Mvc;

namespace FinalAssessmentDotNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly VehicleRepository _vehiclesRepository;

        public VehicleController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "vehicles/all")]
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

        [HttpGet(Name = "vehicles/get/{id}")]
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
        public async Task Post(Vehicle vehicle)
        {
            _context.Add(vehicle);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut(Name = "update")]
        public async Task Put(Vehicle vehicle)
        {
            _context.Update(vehicle);
            await _context.SaveChangesAsync();
            return Ok();
        }


    }
}