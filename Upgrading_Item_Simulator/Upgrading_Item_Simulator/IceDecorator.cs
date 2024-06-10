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
            item.Durability = item.Durability + 50;
            item.AttribType = AttributeType.Ice;
            Durability += 50;
            if(item is Weapon)
            {
                Weapon weapon = (Weapon)item;
                weapon.Damage = weapon.Damage*1.5;
                weapon.CriticalChance = weapon.CriticalChance*1.3;
            }
            else if(item is Armor)
            {
                Armor armor = (Armor)item;
                armor.armorValue += 10;
                armor.chanceToBlock += 0.1;
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
            return decoratedItem.GetStats();
        }
    }
}
