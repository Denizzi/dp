using Decorator;
using Decorator.Beverages;
using Decorator.Condiments;
using Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Executor.ExecuteDecorator();
            //Executor.ExecuteSingleton();
            //Executor.ExecuteStrategy();
            //Executor.ExecuteObserver();
            //Executor.ExecuteFactoryMethod();
            Executor.ExecuteAdapter();
        }
    }
}
