using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class IceDecorator : ItemDecorator
    {
        private double iceDamage { get; set; }
        private double iceResistance { get; set; }
        public IceDecorator(Item item) : base(item)
        {
            this.Durability += 50;
            this.AttribType = AttributeType.Ice;
            if (item is Weapon)
            {
                Weapon weapon = (Weapon)item;
                weapon.Damage = weapon.Damage*1.5;
                weapon.CriticalChance = weapon.CriticalChance*1.3;
                iceDamage =  5;
            }
            else if(item is Armor)
            {
                Armor armor = (Armor)item;
                armor.armorValue += 10;
                armor.chanceToBlock += 0.1;
                iceResistance =  40;
            }
        }
        public override void Upgrade(Resource resource)
        {
            decoratedItem.Upgrade(resource);
            Console.WriteLine("Freezing the item...");
        }
        public override string GetDescription()
        {
            return decoratedItem.GetDescription() + " Frozen";
        }
        public override string GetStats()
        {
            if(decoratedItem is Weapon)
            {
                return decoratedItem.GetStats() + " Ice Damage: " + iceDamage;
            }
            else if(decoratedItem is Armor)
            {
                return decoratedItem.GetStats() + " Ice Resistance: " + iceResistance;
            }
            else
            {
                return decoratedItem.GetStats();
            }
        }
    }
}
