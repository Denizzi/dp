using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Implementations
{
    public class Tea : Beverage
    {
        public override void Brew()
        {
            Console.WriteLine("Tea is steeping...");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding lemon");
        }
    }
}
