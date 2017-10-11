using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string GetName();
    }
}
