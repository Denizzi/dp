using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Character
    {
        private List<Equipment> _equipments = new List<Equipment>();

        public Character()
        {
            CreateEquipments();
        }

        protected List<Equipment> Equipments()
        {
            return _equipments;
        }

        public void Introduce()
        {
            Console.WriteLine("My items are:");
            foreach (var item in _equipments)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("\n");
        }

        public abstract void CreateEquipments();
    }
}
