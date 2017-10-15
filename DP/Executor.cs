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
            //Intent
            //  • Attach additional responsibilities to an object dynamically.
            //      Decorators provide a flexible alternative to subclassing for extending
            //      functionality.
            //  • Client - specified embellishment of a core object by recursively
            //      wrapping it.
            //  • Wrapping a gift, putting it in a box, and wrapping the box.

            //Problem
            //  You want to add behavior or state to individual objects at run-time.
            //  Inheritance is not feasible because it is static and applies to an entire
            //  class.

            Beverage beverage = new Cream(new Cream(new Espresso()));
            Beverage beverage2 = new Mocha(new Milk(new Americano()));


            Console.WriteLine(String.Format($"Beverage: {beverage.GetName()}"));
            Console.WriteLine(String.Format($"Cost: {beverage.GetCost()}"));

            Console.WriteLine(String.Format($"Beverage: {beverage2.GetName()}"));
            Console.WriteLine(String.Format($"Cost: {beverage2.GetCost()}"));
        }

        internal static void ExecuteSingleton()
        {
            //Intent
            //  • Ensure a class has only one instance, and provide a global point of access to it.
            //  • Encapsulated "just-in-time initialization" or "initialization on first use".

            //Problem
            //  Application needs one, and only one, instance of an object.
            //  Additionally, lazy initialization and global access are necessary.

            //NOTES
            //  In many ways, the Singleton Pattern is a convention for ensuring one and only one object is instantiated for a given class.
            //  Just ask yourself: how do I prevent more than one object from being instantiated? It’s not so obvious, is it?
            //  Let’s say you have an object that contains registry settings. You don’t want multiple copies of that object and its values running around 
            //      – that would lead to chaos.By using an object you can assure that every object in your application is making use of the same global resource.

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
            //Intent
            //• Define a one - to - many dependency between objects so that when one object changes state, all its dependents are notified and updated
            //  automatically.
            //• Encapsulate the core(or common or engine) components in a Subject abstraction, and the variable(or optional or user interface)
            //  components in an Observer hierarchy.
            //• The "View" part of Model-View-Controller.

            //Problem
            //A large monolithic design does not scale well as new graphing or monitoring requirements are levied.

            var weatherData = new WeatherData();

            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            var forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(28f, 75f, 1.5f);

            weatherData.RemoveObserver(currentConditionsDisplay);

            weatherData.SetMeasurements(31f, 82f, 1.65f);
        }
        internal static void ExecuteFactoryMethod()
        {
            //Intent
            //• Define an interface for creating an object, but let subclasses decide which class to instantiate.Factory Method lets a class defer
            //  instantiation to subclasses.
            //• Defining a "virtual" constructor.
            //• The new operator considered harmful.

            //Problem
            //A framework needs to standardize the architectural model for a range of applications, but allow for individual applications to define
            //  their own domain objects and provide for their instantiation.

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
