using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverages
{
    public class Americano : Beverage
    {
        public Americano()
        {
            _name = "Americano";
        }

        public override decimal GetCost()
        {
            return 7m;
        }
    }
}
