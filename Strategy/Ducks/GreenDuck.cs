using Strategy.FlyBehaviour;
using Strategy.QuackBehaviour;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    public class GreenDuck : Duck
    {
        public GreenDuck()
        {
            _flyBehaviour = new FlyWithWings();
            _quackBehaviour = new Squeak();
        }
    }
}
