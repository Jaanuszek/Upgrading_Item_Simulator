using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    abstract class Armor : Item
    {
        public double armorValue { get; set; }
        public double chanceToBlock { get; set; }
        public double elemetsResistance { get; set; }
        public Armor()
        {
            ItType = ItemType.None;
            MaterialType = UpgradeType.None;
            AttribType = AttributeType.None;
            Durability = 1;
            armorValue = 1.0;
            chanceToBlock = 1.0;
            elemetsResistance = 1.0;
        }
    }
}
