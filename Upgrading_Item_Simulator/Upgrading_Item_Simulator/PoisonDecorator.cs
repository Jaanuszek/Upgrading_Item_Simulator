using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class PoisonDecorator : ItemDecorator
    {
        private double PoisonDamage { get; set; }
        private double PoisonReduction { get; set; }
        public PoisonDecorator(Item item) : base(item)
        {
            decoratedItem.Durability += 50;
            this.Durability += 50;
            this.AttribType = AttributeType.Poison;
            if (item is Weapon)
            {
                Weapon weapon = (Weapon)item;
                weapon.Damage = weapon.Damage * 1.5;
                weapon.CriticalChance = weapon.CriticalChance * 1.3;
                PoisonDamage =  30;
            }
            else if (item is Armor)
            {
                Armor armor = (Armor)item;
                armor.armorValue += 10;
                armor.chanceToBlock += 0.1;
                PoisonReduction =  10;
            }
        }
        public override void Upgrade(Resource resource)
        {
            decoratedItem.Upgrade(resource);
            Console.WriteLine("Poisoning the item...");
        }
        public override string GetDescription()
        {
            return decoratedItem.GetDescription() + " Poisoned";
        }
        public override string GetStats()
        {
            if(decoratedItem is Weapon)
            {
                return decoratedItem.GetStats() + " Poison Damage: " + PoisonDamage;
            }
            else if(decoratedItem is Armor)
            {
                return decoratedItem.GetStats() + " Poison Reduction: " + PoisonReduction;
            }
            else
            {
                return decoratedItem.GetStats();
            }
        }
    }
}
