using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DisplayElements
{
    public class CurrentConditionsDisplay : WeatherObserver, IDisplayable
    {
        private WeatherSubject _weatherSubject;
        private float _temperature;
        private float _humidity;

        public CurrentConditionsDisplay(WeatherSubject weatherSubject)
        {
            _weatherSubject = weatherSubject;
            weatherSubject.RegisterObserver(this);
        }

        public override void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;

            Display();
        }

        public void Display()
        {
            Console.WriteLine(String.Format($"Current conditions : {_temperature}C degrees and {_humidity}% humidity."));
        }
    }
}
