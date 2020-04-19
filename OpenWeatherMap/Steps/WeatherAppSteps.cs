using static System.Environment;
using TechTalk.SpecFlow;
using static OpenWeatherMap.Domain.AppContext;

namespace OpenWeatherMap.Steps
{
    [Binding]
    public class WeatherAppSteps
    {
        [Given(@"I have a api key for weather app")]
        public void GivenIHaveAApiKeyForWeatherApp()
        {
            apiKey = GetEnvironmentVariable("API_KEY");
            if (apiKey == string.Empty)
            {
                apiKey = "cf67c924369fa98d34fb1a566fe51bb6";
            }
        }
        
        [Given(@"I have the weather deatils for ""(.*)""")]
        public void GivenIHaveTheWeatherDeatilsFor(string cityName)
        {
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
