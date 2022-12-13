using Mde.Navigating.NavStack.Models;
using System.Diagnostics;

namespace Mde.Navigating.NavStack
{
    public partial class StartPage : ContentPage
    {
        protected readonly IWeatherRepository _weatherRepository;
        public StartPage(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            weatherList.ItemsSource = _weatherRepository.GetWeatherTypes();
        }

        private async void OnWeatherClicked(object sender, EventArgs e)
        {
            var button = (Button) sender;
            var weather = (WeatherType) button.CommandParameter;

            var parameters = new Dictionary<string, object> {
                { "type", weather }
            };

            //await Shell.Current.GoToAsync($"//home/weather", parameters);

            var weatherPage = new WeatherPage(_weatherRepository);
            weatherPage.Weather = weather;

            await Navigation.PushAsync(weatherPage);
        }
    }
}