using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Condiments
{
    public class Mocha : CondimentDecorator
    {
        private Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
            _name = "Mocha";
        }

        public override decimal GetCost()
        {
            return _beverage.GetCost() + 1.5m;
        }

        public override string GetName()
        {
            return String.Format($"{_beverage.GetName()}, {_name}");
        }
    }
}
