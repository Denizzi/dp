using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class PenguinAdapter : Duck
    {
        Penguin _penguin;

        public PenguinAdapter(Penguin penguin)
        {
            _penguin = penguin;
        }

        public override void Fly()
        {
            _penguin.Fly();
        }

        public override void Quack()
        {
            _penguin.Honk();
        }
    }
}
