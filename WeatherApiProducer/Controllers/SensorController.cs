using Microsoft.AspNetCore.Mvc;

namespace WeatherApiProducer.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SensorController : ControllerBase
{
    private readonly ILogger<SensorController> _logger;
    private readonly IWeatherDataPublisher _weatherDataPublisher;

    public SensorController(ILogger<SensorController> logger, IWeatherDataPublisher weatherDataPublisher)
    {
        _logger = logger;
        _weatherDataPublisher = weatherDataPublisher;
    }

    [HttpGet(Name = "GetMessage")]
    public string Get()
    {
        return "testing: 1, 2!";
    }

    [HttpPost]
    public async Task Post([FromBody] Weather weather)
    {
        await _weatherDataPublisher.ProduceAsync(weather);
    }
}

