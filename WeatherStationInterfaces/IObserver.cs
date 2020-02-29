using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationInterfaces
{
    /// <summary>Observer interface.</summary>
    public interface IObserver
    {
        /// <summary>Updates the specified sender.</summary>
        /// <param name="sender">The sender.</param>
        /// <param name="info">The <see cref="WeatherStationEventArgs"/> instance containing the event data.</param>
        public void Update(object sender, WeatherStationEventArgs info);
    }
}
