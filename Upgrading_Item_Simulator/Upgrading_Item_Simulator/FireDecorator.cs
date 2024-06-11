using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class FireDecorator : ItemDecorator   
    {
        private double FireDamage { get; set; }
        private double FireResistance { get; set; }
        public FireDecorator(Item item) : base(item)
        {
            this.Durability += 50;
            this.AttribType = AttributeType.Fire;
            decoratedItem.Durability += 50;
            if (item is Weapon)
            {
                Weapon weapon = (Weapon)item;
                weapon.Damage = weapon.Damage * 1.5;
                weapon.CriticalChance = weapon.CriticalChance * 1.3;
                FireDamage =  10;
            }
            else if (item is Armor)
            {
                Armor armor = (Armor)item;
                armor.armorValue += 10;
                armor.chanceToBlock += 0.1;
                FireResistance =  20;
            }
        }
        public override void Upgrade(Resource resource)
        {
            decoratedItem.Upgrade(resource);
            Console.WriteLine("Setting the item on fire...");
        }
        public override string GetDescription()
        {
            return decoratedItem.GetDescription() + " On Fire";
        }
        public override string GetStats()
        {
            if(decoratedItem is Weapon)
            {
                return decoratedItem.GetStats() + " Fire Damage: " + FireDamage;
            }
            else if(decoratedItem is Armor)
            {
                return decoratedItem.GetStats() + " Fire Resistance: " + FireResistance;
            }
            else
            {
                return decoratedItem.GetStats();
            }
        }
    }
}
