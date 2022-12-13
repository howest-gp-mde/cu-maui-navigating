namespace Mde.Navigating.NavStack.Models
{
    public class WeatherRepository : IWeatherRepository
    {
        public IEnumerable<Activity> GetActivitiesForWeather(WeatherType weatherType)
        {
            return weatherActivities[weatherType];
        }

        public IEnumerable<WeatherType> GetWeatherTypes() =>
            Enum.GetValues<WeatherType>().AsEnumerable();

        public IEnumerable<Weather> GetWeathers() =>
            weathers;

        public Weather GetWeather(WeatherType weatherType) => 
            weathers.FirstOrDefault(weather => weather.Type.Equals(weatherType));

        private readonly IEnumerable<Weather> weathers = new List<Weather>
        {
            new Weather
            {
                Type = WeatherType.Sunny,
            },
            new Weather
            {
                Type = WeatherType.Rainy,
            },
            new Weather
            {
                Type = WeatherType.Windy,
            },
            new Weather
            {
                Type = WeatherType.Foggy,
            }
        };

        private readonly IDictionary<WeatherType, Activity[]> weatherActivities 
        = new Dictionary<WeatherType, Activity[]>
        {
            {
                WeatherType.Sunny, new Activity[] 
                {
                    new Activity{
                        Name = "Treasure walk",
                        Description = ""
                    },
                    new Activity{
                        Name = "Hiking",
                        Description = ""
                    },
                    new Activity{
                        Name = "Fishing",
                        Description = ""
                    },
                    new Activity{
                        Name = "Ride a bike",
                        Description = ""
                    },
                }
            },
            {
                WeatherType.Windy, new Activity[]
                {
                    new Activity{
                        Name = "Fly a kite",
                        Description = ""
                    },
                    new Activity{
                        Name = "Blown messages",
                        Description = ""
                    },
                    new Activity{
                        Name = "Make a windsock",
                        Description = ""
                    },
                    new Activity{
                        Name = "Paper bag chase",
                        Description = ""
                    },
                }
            },
            {
                WeatherType.Foggy, new Activity[]
                {
                    new Activity{
                        Name = "Hide and seek",
                        Description = ""
                    },
                    new Activity{
                        Name = "Blind man's bluff",
                        Description = ""
                    },
                    new Activity{
                        Name = "Reflection trail",
                        Description = ""
                    },
                }
            },
            {
                WeatherType.Rainy, new Activity[]
                {
                    new Activity{
                        Name = "Puddle jumping",
                        Description = ""
                    },
                }
            },
        };
    }
}
