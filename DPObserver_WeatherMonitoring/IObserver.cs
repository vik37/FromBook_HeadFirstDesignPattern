using System;
using System.Collections.Generic;
using System.Text;

namespace DPObserver_WeatherMonitoring
{
    public interface IObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}
