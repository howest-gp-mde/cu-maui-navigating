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
                        Id = "treasurewalk",
                        Name = "Treasure walk",
                        Description = "Go out on a gamified walking trail such as GeoCaching. Discover hidden treasures and explore new places."
                    },
                    new Activity{
                        Id = "hiking",
                        Name = "Hiking",
                        Description = "Ah, the great outdoors! Put on your walking shoes, pack your lunch - or maybe even your tent - and set off on a trail through nature."
                    },
                    new Activity{
                        Id = "fishing",
                        Name = "Fishing",
                        Description = "Relax with your friends next to the water and catch some fish while you're at it."
                    },
                    new Activity{
                        Id = "rideabike",
                        Name = "Ride a bike",
                        Description = "Get a breeze in your hair and watch the landscape change. Pick a preset biking route, or just hop on the bike without any clear destination."
                    },
                }
            },
            {
                WeatherType.Windy, new Activity[]
                {
                    new Activity {
                        Id = "flyakite",
                        Name = "Fly a kite",
                        Description = "Kites come in all kinds and shapes. See how high your kite can go, or launch a double handed kite to boast your loopings."
                    },
                    new Activity {
                        Id = "blownmessage",
                        Name = "Blown messages",
                        Description = "Write a secret message meant for a single person in the group. Let it fly and have everybody try to catch it in the wind."
                    },
                    new Activity {
                        Id = "makewindsock",
                        Name = "Make a windsock",
                        Description = "Experiment with the wind! Make a windsock out of old fabric. Can you measure the windspeed and direction?"
                    }
                }
            },
            {
                WeatherType.Foggy, new Activity[]
                {
                    new Activity {
                        Id = "hideandseek",
                        Name = "Hide and seek",
                        Description = "Have everybody hide while one person needs to find everyone. The fog will make it extra challenging."
                    },
                    new Activity {
                        Id = "blindmansbluff",
                        Name = "Blind man's bluff",
                        Description = "Take the blindfolded person outside and have him find the others. Every so often the others can call him from the mist. No blindfold needed if it's very foggy!"
                    },
                    new Activity {
                        Id = "reflectiontrail",
                        Name = "Reflection trail",
                        Description = "Make a fun obstacle course and mark the route using reflextive materials. Participants will need to find the markers in the mist in order to continue with the next challenge."
                    },
                }
            },
            {
                WeatherType.Rainy, new Activity[]
                {
                    new Activity {
                        Id = "puddlejumping",
                        Name = "Puddle jumping",
                        Description = "Put on your boots and displace some water by jumping in the puddles."
                    },
                    new Activity {
                        Id = "watermill",
                        Name = "Watermill",
                        Description = "Create your own contraption to collect water. Now you can make it run down a channel with a water wheel."
                    },
                    new Activity {
                        Id = "avoidthedrops",
                        Name = "Avoid the drops",
                        Description = "The water is lava! Run a short distance from one roof to another holding a cardboard over your head. The one with the least drops on the board wins."
                    },
                }
            },
        };
    }
}
