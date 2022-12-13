namespace Mde.Navigating.NavStack.Models
{
    public class Weather
    {
        public WeatherType Type { get; set; }

        public string Name => Type.ToString();
    }
}
