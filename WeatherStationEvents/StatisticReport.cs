using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationEvents
{
    /// <summary>Statistic report.</summary>
    public class StatisticReport
    {
        /// <summary>Reports the specified sender.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="info">The <see cref="WeatherStationEventArgs"/> instance containing the event data.</param>
        /// <exception cref="ArgumentNullException">Thrown when info is null.</exception>
        public void Report(object sender, WeatherStationEventArgs info)
        {
            if (info is null)
            {
                throw new ArgumentNullException(nameof(info));
            }

            Console.WriteLine($"Temperature change: {info.CurrentData.Temperature - info.PreviousData.Temperature}.");
            Console.WriteLine($"Humidity change: {info.CurrentData.Humidity - info.PreviousData.Humidity}.");
            Console.WriteLine($"Pressure change: {info.CurrentData.Pressure - info.PreviousData.Pressure}.");
            Console.WriteLine();
        }
    }
}
