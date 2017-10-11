using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DisplayElements
{
    public class ForecastDisplay : WeatherObserver, IDisplayable
    {
        private WeatherSubject _weatherSubject;
        private float _temperature;
        private float _humidity;
        private float _pressure;
        public ForecastDisplay(WeatherSubject weatherSubject)
        {
            _weatherSubject = weatherSubject;
            weatherSubject.RegisterObserver(this);
        }
        public override void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            Display();
        }
        public void Display()
        {
            Console.WriteLine(String.Format($"Forecast// Temperature: {_temperature}C, Humidity: {_humidity}%, Pressure: {_pressure}bar"));
        }
    }
}
