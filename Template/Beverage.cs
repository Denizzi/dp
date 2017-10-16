using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class Beverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        private void BoilWater()
        {
            Console.WriteLine("Water is boiling...");
        }

        private void PourInCup()
        {
            Console.WriteLine("You pour the beverage into cup.");
        }

        public abstract void Brew();
        public abstract void AddCondiments();
    }
}
