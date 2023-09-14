using BlazorApp.Data;

namespace BlazorApp.Pages
{
    public class Test
    {
        private readonly WeatherForecastService _weatherForecastService;

        public Test(WeatherForecastService weatherForecastService )
        {
            _weatherForecastService = weatherForecastService;
        }
    }
}
