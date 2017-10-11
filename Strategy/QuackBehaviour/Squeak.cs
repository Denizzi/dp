using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.QuackBehaviour
{
    public class Squeak : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Squeeaaak");
        }
    }
}
