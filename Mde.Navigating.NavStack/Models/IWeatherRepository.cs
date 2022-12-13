namespace Mde.Navigating.NavStack.Models
{
    public interface IWeatherRepository
    {
        IEnumerable<Activity> GetActivitiesForWeather(WeatherType weatherType);
        IEnumerable<WeatherType> GetWeatherTypes();
        public IEnumerable<Weather> GetWeathers();
        Weather GetWeather(WeatherType weatherType);
    }
}