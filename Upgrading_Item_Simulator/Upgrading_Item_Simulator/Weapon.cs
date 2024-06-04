using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    abstract class Weapon : Item { 
        public double Damage { get;  set; }
        public double CriticalChance { get; set; }
        public Weapon()
        {
            Durability = 0;
            Damage = 0.0;
            CriticalChance = 0.0;
        }

    }
}
