﻿using System;
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
        public ItemType item { get; set; }
        public UpgradeType upgradeType { get; set; }
        public AttributeType attributeType { get; set; }
        //dodanie enuma i zmiana argumentu konstruktora na ItemType
        public Order(ItemType item, UpgradeType upgradeType, AttributeType attributeType)
        {
            this.item = item;
            this.upgradeType = upgradeType;
            this.attributeType = attributeType;
        }
        public string GetValues() //zamiana na string z void
        { 
            return "Item type: " + item.ToString() + ", " + "Material type: " + upgradeType.ToString() + ", " + "Attribute Type:"+ attributeType.ToString();
        }
    }
}
