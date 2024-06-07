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
        //private Item item;
        private ItemType item;
        private UpgradeType upgradeType;
        private AttributeType attributeType;
        //dodanie enuma i zmiana argumentu konstruktora na ItemType
        public Order(ItemType item, UpgradeType upgradeType, AttributeType attributeType)
        {
            this.item = item;
            this.upgradeType = upgradeType;
            this.attributeType = attributeType;
        }
        public void GetValues()
        {
            Console.WriteLine(item.ToString()+ " " + upgradeType.ToString()+ " " + attributeType.ToString());
        }
    }
}
