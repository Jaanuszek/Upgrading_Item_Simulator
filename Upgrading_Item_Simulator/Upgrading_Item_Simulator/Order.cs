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
    public enum ItemType
    {
        Dagger,
        Sword,
        Axe,
        Bow,
        Chestplate,
        Helmet,
        Boots,
        None
    }
    class Order
    {
        public ItemType item { get; set; }
        public UpgradeType upgradeType { get; set; }
        public AttributeType attributeType { get; set; }
        public Order(ItemType item, UpgradeType upgradeType, AttributeType attributeType)
        {
            this.item = item;
            this.upgradeType = upgradeType;
            this.attributeType = attributeType;
        }
        public string GetValues()
        { 
            return "Item type: " + item.ToString() + ", " + "Material type: " + upgradeType.ToString() + ", " + "Attribute Type:"+ attributeType.ToString();
        }
    }
}
