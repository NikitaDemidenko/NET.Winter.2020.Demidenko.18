using System;

namespace WeatherStationEvents
{
    class Program
    {
        static void Main()
        {
            var weatherStation = new WeatherStation();
            var conditionReporter = new CurrentConditionsReport();
            var statisticReporter = new StatisticReport();

            weatherStation.WeatherChanged += conditionReporter.Report;
            weatherStation.WeatherChanged += statisticReporter.Report;

            var currentWeather = new WeatherData
            {
                Temperature = 25.2f,
                Humidity = 85f,
                Pressure = 730f,
            };

            weatherStation.EmulateWeatherChange();
            weatherStation.EmulateWeatherChange();
            weatherStation.EmulateWeatherChange();

            weatherStation.WeatherChanged -= statisticReporter.Report;

            weatherStation.EmulateWeatherChange();
            weatherStation.EmulateWeatherChange();
        }
    }
}
