using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationInterfaces
{
    /// <summary>Observable interface.</summary>
    public interface IObservable
    {
        /// <summary>Adds the observer.</summary>
        /// <param name="observer">The observer.</param>
        public void AddObserver(IObserver observer);

        /// <summary>Notifies the observers.</summary>
        public void NotifyObservers();

        /// <summary>Removes the observer.</summary>
        /// <param name="observer">The observer.</param>
        public void RemoveObserver(IObserver observer);
    }
}
