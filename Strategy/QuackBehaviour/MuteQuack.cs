using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.QuackBehaviour
{
    public class MuteQuack : IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("<silence>");
        }
    }
}
