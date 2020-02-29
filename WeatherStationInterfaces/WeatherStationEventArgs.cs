using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationInterfaces
{
    /// <summary>Weather station event arguments.</summary>
    /// <seealso cref="EventArgs" />
    public class WeatherStationEventArgs : EventArgs
    {
        /// <summary>Initializes a new instance of the <see cref="WeatherStationEventArgs"/> class.</summary>
        /// <param name="currentData">The current data.</param>
        /// <param name="previousData">The previous data.</param>
        /// <exception cref="ArgumentNullException">Thrown when currentData or previousData is null.</exception>
        public WeatherStationEventArgs(WeatherData currentData, WeatherData previousData)
        {
            this.CurrentData = currentData ?? throw new ArgumentNullException(nameof(currentData));
            this.PreviousData = previousData ?? throw new ArgumentNullException(nameof(previousData));
        }

        /// <summary>Gets or sets the current data.</summary>
        /// <value>The current data.</value>
        public WeatherData CurrentData { get; set; }

        /// <summary>Gets or sets the previous data.</summary>
        /// <value>The previous data.</value>
        public WeatherData PreviousData { get; set; }
    }
}
