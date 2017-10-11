using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Condiments
{
    public class Cream : CondimentDecorator
    {
        private Beverage _beverage;

        public Cream(Beverage beverage)
        {
            _beverage = beverage;
            _name = "Cream";
        }

        public override decimal GetCost()
        {
            return _beverage.GetCost() + 0.75m;
        }

        public override string GetName()
        {
            return String.Format($"{_beverage.GetName()}, {_name}");
        }
    }
}
