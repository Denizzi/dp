using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.FlyBehaviour
{
    public class FlyWithRockets : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Ciuvvvvvvvvvvv");
        }
    }
}
