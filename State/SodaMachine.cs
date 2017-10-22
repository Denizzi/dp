using State.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class SodaMachineContext
    {
        private SodaMachineState _currentState;

        public SodaMachineState HasCoinState { get; private set; }
        public SodaMachineState NoCoinState { get; private set; }

        public SodaMachineContext()
        {
            HasCoinState = new HasCoinState(this);
            NoCoinState = new NoCoinState(this);

            _currentState = NoCoinState;
        }
        
        public void SetState(SodaMachineState state)
        {
            _currentState = state;
        }

        public void InsertCoin()
        {
            _currentState.InsertCoin();
        }

        public void EjectCoin()
        {
            _currentState.EjectCoin();
        }

        public void PressGetSodaButton()
        {
            _currentState.PressGetSodaButton();
        }
    }
}
