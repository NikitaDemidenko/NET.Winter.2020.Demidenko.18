﻿using System;

namespace WeatherStationEvents
{
    public static class Program
    {
        public static void Main()
        {
            var weatherStation = new WeatherStation();
            var conditionReporter = new CurrentConditionsReport();
            var statisticReporter = new StatisticReport();

            weatherStation.WeatherChanged += conditionReporter.Report;
            weatherStation.WeatherChanged += statisticReporter.Report;

            weatherStation.EmulateWeatherChange();
            weatherStation.EmulateWeatherChange();
            weatherStation.EmulateWeatherChange();

            weatherStation.WeatherChanged -= statisticReporter.Report;

            weatherStation.EmulateWeatherChange();
            weatherStation.EmulateWeatherChange();
        }
    }
}
