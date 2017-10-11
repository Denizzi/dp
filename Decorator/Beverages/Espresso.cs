using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            _name = "Espresso";
        }

        public override decimal GetCost()
        {
            return 6.5m;
        }
    }
}
