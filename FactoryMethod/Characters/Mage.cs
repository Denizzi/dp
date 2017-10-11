using FactoryMethod.Equipments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Characters
{
    public class Mage : Character
    {
        public override void CreateEquipments()
        {
            Equipments().Add(new SpellBook());
            Equipments().Add(new Robe());
        }
    }
}
