using static System.Environment;
using TechTalk.SpecFlow;
using static OpenWeatherMap.Domain.AppContext;
using static System.Configuration.ConfigurationManager;
using OpenWeatherMap.ScreenPlay;

namespace OpenWeatherMap.Steps
{
    [Binding]
    public class WeatherAppSteps
    {
        [Given(@"I have a api key for weather app")]
        public void GivenIHaveAApiKeyForWeatherApp()
        {
            apiKey = GetEnvironmentVariable("API_KEY") ?? "439d4b804bc8187953eb36d2a8c26a02";
            System.Console.WriteLine(apiKey + "\n\n\n\n");
        }

        [Given(@"I have app url for weather app")]
        public void GivenIHaveAppUrlForWeatherApp()
        {
            appUrl = AppSettings["appurl"] ?? "api.openweathermap.org";
        }

        [Given(@"I have the weather deatils for ""(.*)""")]
        public void GivenIHaveTheWeatherDeatilsFor(string cityName)
        {
            CurrentWeather currentWeather = new CurrentWeather();
            currentWeather.by(cityName);
        }
        
        [Then(@"I print the minimum tempeature to console")]
        public void ThenIPrintTheMinimumTempeatureToConsole()
        {
            
        }
        
        [Then(@"I print the maximum temperature to console")]
        public void ThenIPrintTheMaximumTemperatureToConsole()
        {
            
        }
    }
}
