using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationInterfaces
{
    /// <summary>Weather data.</summary>
    public class WeatherData
    {
        /// <summary>Gets or sets the temperature.</summary>
        /// <value>The temperature.</value>
        public float Temperature { get; set; }

        /// <summary>Gets or sets the humidity.</summary>
        /// <value>The humidity.</value>
        public float Humidity { get; set; }

        /// <summary>Gets or sets the pressure.</summary>
        /// <value>The pressure.</value>
        public float Pressure { get; set; }
    }
}
