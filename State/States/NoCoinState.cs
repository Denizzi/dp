using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class NoCoinState : SodaMachineState
    {
        private SodaMachineContext _sodaMachine;

        public NoCoinState(SodaMachineContext sodaMachine)
        {
            _sodaMachine = sodaMachine;
        }

        public override void EjectCoin()
        {
            Console.WriteLine("You did not insert a coin!");
        }

        public override void InsertCoin()
        {
            Console.WriteLine("Coin is inserted.");
            _sodaMachine.SetState(_sodaMachine.HasCoinState);
        }

        public override void PressGetSodaButton()
        {
            Console.WriteLine("You pressed the button but nothing happened. You should insert a coin first in order to get a soda!");
        }
    }
}
