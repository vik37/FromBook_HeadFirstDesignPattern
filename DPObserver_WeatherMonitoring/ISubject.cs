using System;
using System.Collections.Generic;
using System.Text;

namespace DPObserver_WeatherMonitoring
{
    public interface ISubject
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObserver();
    }
}
