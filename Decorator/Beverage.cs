using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Beverage
    {
        protected string _name;

        public Beverage()
        {
            _name = "Unknown";
        }

        public virtual string GetName()
        {
            return _name;
        }

        public abstract decimal GetCost();
    }
}
