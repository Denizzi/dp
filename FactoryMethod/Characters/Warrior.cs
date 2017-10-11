using FactoryMethod.Equipments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Characters
{
    public class Warrior : Character
    {
        public override void CreateEquipments()
        {

            Equipments().Add(new Sword());
            Equipments().Add(new Shield());
            Equipments().Add(new PlateArmor());
        }
    }
}
