using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationInterfaces
{
    /// <summary>Current weather condition report.</summary>
    public class CurrentConditionsReport : IObserver
    {
        /// <summary>Reports the specified sender.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="info">The <see cref="WeatherStationEventArgs"/> instance containing the event data.</param>
        /// <exception cref="ArgumentNullException">Thrown when info is null.</exception>
        public void Update(object sender, WeatherStationEventArgs info)
        {
            if (info is null)
            {
                throw new ArgumentNullException(nameof(info));
            }

            Console.WriteLine($"Current temperature: {info.CurrentData.Temperature}.");
            Console.WriteLine($"Current humidity: {info.CurrentData.Humidity}.");
            Console.WriteLine($"Current pressure: {info.CurrentData.Pressure}.");
            Console.WriteLine();
        }
    }
}
