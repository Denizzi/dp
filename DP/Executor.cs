using Adapter;
using Adapter.Penguins;
using Decorator;
using Decorator.Beverages;
using Decorator.Condiments;
using FactoryMethod;
using FactoryMethod.Characters;
using Observer.DisplayElements;
using Observer.Subject;
using Singleton;
using Strategy;
using Strategy.Ducks;
using Strategy.FlyBehaviour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class Executor
    {
        internal static void ExecuteDecorator()
        {
            Beverage beverage = new Cream(new Cream(new Espresso()));
            Beverage beverage2 = new Mocha(new Milk(new Americano()));


            Console.WriteLine(String.Format($"Beverage: {beverage.GetName()}"));
            Console.WriteLine(String.Format($"Cost: {beverage.GetCost()}"));

            Console.WriteLine(String.Format($"Beverage: {beverage2.GetName()}"));
            Console.WriteLine(String.Format($"Cost: {beverage2.GetCost()}"));
        }

        internal static void ExecuteSingleton()
        {
            //SingletonFirstVersion sfv = new SingletonFirstVersion();
            SingletonFirstVersion sfv2 = SingletonFirstVersion.Instance;

            //SingletonThreadSafe sts = new SingletonThreadSafe();
            SingletonThreadSafe sts2 = SingletonThreadSafe.Instance;
        }

        internal static void ExecuteStrategy()
        {
            //Strategy.Duck greenDuck = new GreenDuck();
            //greenDuck.PerformFly();
            //greenDuck.PerformQuack();

            Strategy.Duck rubberDuck = new RubberDuck();
            //rubberDuck.PerformFly();
            //rubberDuck.PerformQuack();

            rubberDuck.SetFlyBehaviour(new FlyWithRockets()); // Changing behaviour at runtime !
            rubberDuck.PerformFly();
        }

        internal static void ExecuteObserver()
        {
            var weatherData = new WeatherData();

            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            var forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(28f, 75f, 1.5f);

            weatherData.RemoveObserver(currentConditionsDisplay);

            weatherData.SetMeasurements(31f, 82f, 1.65f);
        }
        internal static void ExecuteFactoryMethod()
        {
            Character warrior = new Warrior();
            warrior.Introduce();

            Character mage = new Mage();
            mage.Introduce();
        }

        internal static void ExecuteAdapter()
        {
            //Intent
            //• Convert the interface of a class into another interface clients expect.
            //  Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
            //• Wrap an existing class with a new interface.
            //• Impedance match an old component to a new system

            //Problem
            //An "off the shelf" component offers compelling functionality that you would like to reuse, but its "view of the world" is not compatible
            //  with the philosophy and architecture of the system currently being developed.

            Penguin kingPenguin = new KingPenguin();
            Adapter.Duck penguin = new PenguinAdapter(kingPenguin);

            penguin.Fly();
            penguin.Quack();
        }
    }
}
