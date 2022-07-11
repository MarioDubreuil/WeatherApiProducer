
namespace WeatherApiProducer
{
    public interface IWeatherDataPublisher
    {
        Task ProduceAsync(Weather weather);
    }
}