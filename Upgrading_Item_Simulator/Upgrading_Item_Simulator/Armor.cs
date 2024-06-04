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
            Durability = 0;
            armorValue = 0.0;
            chanceToBlock = 0.0;
            elemetsResistance = 0.0;
        }
    }
}
