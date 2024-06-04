using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    public enum UpgradeType
    {
        Wood,
        Iron,
        Gold,
        Diamond,
        None
    }
    public enum AttributeType
    {
        Fire,
        Ice,
        Poison,
        None
    }
    class Order
    {
        private Item item;
        private UpgradeType upgradeType;
        private AttributeType attributeType;
        public Order(Item item, UpgradeType upgradeType, AttributeType attributeType)
        {
            this.item = item;
            this.upgradeType = upgradeType;
            this.attributeType = attributeType;
        }
    }
}
