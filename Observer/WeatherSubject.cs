using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class WeatherSubject
    {
        public abstract void RegisterObserver(WeatherObserver observer);
        public abstract void RemoveObserver(WeatherObserver observer);
        public abstract void NotifyObservers();
    }
}
