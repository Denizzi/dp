using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public abstract class SodaMachineState
    {
        public abstract void InsertCoin();
        public abstract void EjectCoin();
        public abstract void PressGetSodaButton();
    }
}
