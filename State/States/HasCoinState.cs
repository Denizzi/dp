using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class HasCoinState : SodaMachineState
    {
        private SodaMachineContext _sodaMachine;

        public HasCoinState(SodaMachineContext sodaMachine)
        {
            _sodaMachine = sodaMachine;
        }

        public override void EjectCoin()
        {
            Console.WriteLine("You get your coin back.");
            _sodaMachine.SetState(_sodaMachine.NoCoinState);
        }

        public override void InsertCoin()
        {
            Console.WriteLine("There's already a coin inside! You can't insert more than one coin.");
        }

        public override void PressGetSodaButton()
        {
            Console.WriteLine("You get your drink. Cheers!");
            _sodaMachine.SetState(_sodaMachine.NoCoinState);
        }
    }
}
