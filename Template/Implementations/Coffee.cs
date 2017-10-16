using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Implementations
{
    public class Coffee : Beverage
    {
        public override void Brew()
        {
            Console.WriteLine("Coffee is getting filtered.");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Adding milk");
        }
    }
}
