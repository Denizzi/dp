using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Ducks
{
    public class GreenDuck : Duck
    {
        public override void Fly()
        {
            Console.WriteLine("I fly with my wings !");
        }

        public override void Quack()
        {
            Console.WriteLine("Quack quack !");
        }
    }
}
