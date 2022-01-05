using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPObserver_WeatherMonitoring
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }
        
        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }
        public void RemoveObserver(IObserver o)
        {
            int index = _observers.IndexOf(o);
            if(index >= 0)
            {
                _observers.RemoveAt(index);
            }
        }
        public void NotifyObserver()
        {
            for (int i = 0; i < _observers.Count; i++)
            {
                IObserver obs = _observers.ElementAt(i);
                obs.Update(_temperature, _humidity, _pressure);
            }
        }      
        public void MeasurementsChanged()
        {
            NotifyObserver();
        }
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            MeasurementsChanged();
        }
    }
}
