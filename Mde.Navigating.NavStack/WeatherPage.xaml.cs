using Mde.Navigating.NavStack.Models;

namespace Mde.Navigating.NavStack;

[QueryProperty(nameof(Weather), "type")]
public partial class WeatherPage : ContentPage
{
    protected readonly IWeatherRepository _weatherRepository;

    public WeatherPage(IWeatherRepository weatherRepository)
    {
        _weatherRepository = weatherRepository;

        InitializeComponent();
    }

    private WeatherType weather;

    public WeatherType Weather
    {
        get { return weather; }
        set { weather = value; }
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        Title = Weather.ToString();
        imgWeather.Source = $"{Weather.ToString().ToLower()}.png";
        spanWeather.Text = Weather.ToString();
        activityList.ItemsSource = _weatherRepository.GetActivitiesForWeather(Weather);
    }


    private async void OnActivityClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        var activity = (Activity)button.CommandParameter;

        var parameters = new Dictionary<string, object> {
                { "activity", activity }
            };

        await Shell.Current.GoToAsync($"//home/weather/activity", parameters);

        //var detailPage = new ActivityDetailPage();
        //detailPage.Activity = activity;

        //await Navigation.PushAsync(detailPage);
    }
}