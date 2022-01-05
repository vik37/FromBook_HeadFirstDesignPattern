using System;
using System.Collections.Generic;
using System.Text;

namespace DPObserver_WeatherMonitoring
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private float _preasure;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this._weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._preasure = pressure;
            Display();
        }
        public void Display()
        {
            Console.WriteLine($"Current condition: \n {_temperature} F degrees and {_humidity} % humidity " +
                                $"\n air pressure: {_preasure}");
        }

        
    }
}
