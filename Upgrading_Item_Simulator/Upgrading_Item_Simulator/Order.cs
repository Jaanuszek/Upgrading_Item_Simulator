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
        Diamond
    }
    public enum AttributeType
    {
        Fire,
        Ice,
        Poison
    }
    class Order
    {
        private IItem item;
        private UpgradeType upgradeType;
        private AttributeType attributeType;
        public Order(IItem item, UpgradeType upgradeType, AttributeType attributeType)
        {
            this.item = item;
            this.upgradeType = upgradeType;
            this.attributeType = attributeType;
        }
    }
}
