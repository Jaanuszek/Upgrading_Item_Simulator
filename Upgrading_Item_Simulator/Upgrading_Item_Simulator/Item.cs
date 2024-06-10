using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    abstract class Item
    {
        public int Durability { get; set; }
        public ItemType ItType { get; set; }//
        public UpgradeType MaterialType { get; set; }//
        public AttributeType AttribType { get; set; }//
        public abstract void Upgrade(Resource resource);
        public abstract string GetDescription();
        public abstract string GetStats();
    }
}
