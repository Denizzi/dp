using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Condiments
{
    public class Milk : CondimentDecorator
    {
        private Beverage _beverage;

        public Milk(Beverage beverage)
        {
            _beverage = beverage;
            _name = "Milk";
        }

        public override decimal GetCost()
        {
            return _beverage.GetCost() + 1.25m;
        }

        public override string GetName()
        {
            return String.Format($"{_beverage.GetName()}, {_name}");
        }
    }
}
