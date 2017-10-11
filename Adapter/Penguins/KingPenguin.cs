using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Penguins
{
    public class KingPenguin : Penguin
    {
        public override void Fly()
        {
            Console.WriteLine("I can not fly :/");
        }

        public override void Honk()
        {
            Console.WriteLine("Honk honk !");
        }
    }
}
