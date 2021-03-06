using System;

namespace DPObserver_WeatherMonitoring
{
    class Program
    {
        /* The observer pattern defines a one-to-many dependency
         *  between objects so that when one object change state,
         *  all of its dependents are notified and updated automatically
         */
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statistic = new StatisticsDisplay(weatherData);
            weatherData.SetMeasurements(80, 65, 34.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);
            weatherData.SetMeasurements(86, 48, 27.8f);
            weatherData.RemoveObserver(statistic);
            weatherData.SetMeasurements(73, 40, 49.2f);
            weatherData.SetMeasurements(81, 58, 22.1f);
            Console.ReadLine();
        }
    }
}
