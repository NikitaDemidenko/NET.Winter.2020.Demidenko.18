using System;

namespace WeatherStationInterfaces
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var weatherStation = new WeatherStation();
            var conditionReporter = new CurrentConditionsReport();
            var statisticReporter = new StatisticReport();

            weatherStation.AddObserver(conditionReporter);
            weatherStation.AddObserver(statisticReporter);

            weatherStation.EmulateWeatherChange();
            weatherStation.EmulateWeatherChange();
            weatherStation.EmulateWeatherChange();

            weatherStation.RemoveObserver(statisticReporter);

            weatherStation.EmulateWeatherChange();
            weatherStation.EmulateWeatherChange();
        }
    }
}
