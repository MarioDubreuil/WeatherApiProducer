using Microsoft.AspNetCore.Mvc;

namespace WeatherApiProducer.Controllers;

[ApiController]
[Route("[controller]")]
public class SensorController : ControllerBase
{
    private readonly ILogger<SensorController> _logger;

    public SensorController(ILogger<SensorController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetMessage")]
    public string Get()
    {
        return "testing: 1, 2!";
    }
}

