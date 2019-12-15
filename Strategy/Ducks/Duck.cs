using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Duck
    {
        //Favor composition over inheritance
        //Multiple Behaviours
        protected IFlyable _flyBehaviour;
        protected IQuackable _quackBehaviour;
        public Duck()
        {

        }

        public void PerformFly()
        {
            _flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            _quackBehaviour.Quack();
        }

        public void SetFlyBehaviour(IFlyable flyBehaviour)
        {
            _flyBehaviour = flyBehaviour;
        }

        public void SetQuackBehaviour(IQuackable quackBehaviour)
        {
            _quackBehaviour = quackBehaviour;
        }
    }
}
