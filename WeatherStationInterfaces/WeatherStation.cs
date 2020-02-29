using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationInterfaces
{
    /// <summary>Weather station.</summary>
    public class WeatherStation : IObservable
    {
        private readonly Random random = new Random();
        private List<IObserver> observers;
        private WeatherData currentData;
        private WeatherData previousData;

        /// <summary>Initializes a new instance of the <see cref="WeatherStation"/> class.</summary>
        public WeatherStation()
        {
            this.observers = new List<IObserver>();
            this.currentData = new WeatherData();
            this.previousData = new WeatherData();
        }

        /// <summary>Gets the current data.</summary>
        /// <value>The current data.</value>
        public WeatherData CurrentData
        {
            get => this.currentData;
            private set
            {
                if (value != this.currentData)
                {
                    this.previousData = this.currentData;
                    this.currentData = value;
                }
            }
        }

        /// <summary>Gets the previous data.</summary>
        /// <value>The previous data.</value>
        public WeatherData PreviousData => this.previousData;

        /// <summary>Adds the observer.</summary>
        /// <param name="observer">The observer.</param>
        /// <exception cref="System.ArgumentNullException">Thrown when observer is null.</exception>
        public void AddObserver(IObserver observer)
        {
            if (observer is null)
            {
                throw new ArgumentNullException(nameof(observer));
            }

            if (!this.observers.Contains(observer))
            {
                this.observers.Add(observer);
            }
        }

        /// <summary>Notifies the observers.</summary>
        public void NotifyObservers()
        {
            foreach (var observer in this.observers)
            {
                observer.Update(this, new WeatherStationEventArgs(this.currentData, this.previousData));
            }
        }

        /// <summary>Removes the observer.</summary>
        /// <param name="observer">The observer.</param>
        /// <exception cref="System.ArgumentNullException">Thrown when observer is null.</exception>
        public void RemoveObserver(IObserver observer)
        {
            if (observer is null)
            {
                throw new ArgumentNullException(nameof(observer));
            }

            if (this.observers.Contains(observer))
            {
                this.observers.Remove(observer);
            }
        }

        /// <summary>Emulates the weather change.</summary>
        public void EmulateWeatherChange()
        {
            var currentWeather = new WeatherData
            {
                Temperature = this.random.Next(-100, 100),
                Humidity = this.random.Next(0, 100),
                Pressure = this.random.Next(600, 1000),
            };

            this.CurrentData = currentWeather;
            this.NotifyObservers();
        }
    }
}
