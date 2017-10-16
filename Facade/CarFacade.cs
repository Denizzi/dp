using Facade.SubSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class CarFacade
    {
        private readonly CarBody body;
        private readonly CarEngine engine;
        private readonly CarModel model;

        public CarFacade()
        {
            body = new CarBody();
            engine = new CarEngine();
            model = new CarModel();
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine("# Creating a car #");
            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            Console.WriteLine("# Car creation is completed. #");
        }
    }
}
