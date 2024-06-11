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
            ItType = ItemType.None;
            MaterialType = UpgradeType.None;
            AttribType = AttributeType.None;
            Durability = 1;
            Damage = 1.0;
            CriticalChance = 1.0;
        }

    }
}
