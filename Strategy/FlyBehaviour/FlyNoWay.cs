using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.FlyBehaviour
{
    public class FlyNoWay : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I can not fly :(");
        }
    }
}
