using Strategy.FlyBehaviour;
using Strategy.QuackBehaviour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            _flyBehaviour = new FlyNoWay();
            _quackBehaviour = new Quacky();
        }
    }
}
