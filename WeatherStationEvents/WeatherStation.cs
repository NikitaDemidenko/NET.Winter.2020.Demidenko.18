using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherStationEvents
{
    /// <summary>Weather station.</summary>
    public class WeatherStation
    {
        private readonly Random random = new Random();
        private WeatherData currentData;
        private WeatherData previousData;

        /// <summary>Initializes a new instance of the <see cref="WeatherStation"/> class.</summary>
        public WeatherStation()
        {
            this.currentData = new WeatherData();
            this.previousData = new WeatherData();
        }

        /// <summary>Occurs when weather is changed.</summary>
        public event EventHandler<WeatherStationEventArgs> WeatherChanged;

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
                    this.OnWeatherChanged(new WeatherStationEventArgs(this.currentData, this.previousData));
                }
            }
        }

        /// <summary>Gets the previous data.</summary>
        /// <value>The previous data.</value>
        public WeatherData PreviousData => this.previousData;

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
        }

        /// <summary>Raises the <see cref="WeatherChanged"/> event.</summary>
        /// <param name="info">The <see cref="WeatherStationEventArgs"/> instance containing the event data.</param>
        protected virtual void OnWeatherChanged(WeatherStationEventArgs info)
        {
            this.WeatherChanged?.Invoke(this, info);
        }
    }
}
