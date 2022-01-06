using System;
using System.Collections.Generic;
using System.Text;

namespace DPObserver_WeatherMonitoring
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private float _preasure;
        private ISubject _weatherData;
        private float _min;
        private float _avg;
        private float _max;
        public StatisticsDisplay(ISubject weatherData)
        {
            this._weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        
        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Month Statistics: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine( $" maximum temperature these days: {_max} " +
                               $"\n minimum temperature these days: {_min} " +
                                $"\n and average: {_avg}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("*****************************************************************");
            
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._preasure = pressure;

            if(this._min >= _temperature || this._max == 0)
            {
                this._min = _temperature;
            }
            if(this._max <= _temperature)
            {
                this._max = _temperature;
            }
            this._avg = (this._min + this._max) / 2;
            Display();
        }
    }
}
