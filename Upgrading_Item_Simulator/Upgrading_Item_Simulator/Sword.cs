using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class Sword :Weapon
    {
        private double swingingDamage { get; set; }
        public Sword() : base()
        {
            swingingDamage = 0;
            ItType= ItemType.Sword;
        }
        public override void Upgrade(Resource resource)
        {
            switch (resource)
            {
                case (Wood):
                    Damage += 2;
                    Durability += 10;
                    CriticalChance = 5.0;
                    swingingDamage += 1;
                    MaterialType = UpgradeType.Wood;
                    break;
                case (Iron):
                    Damage += 4;
                    Durability += 20;
                    CriticalChance = 10.0;
                    swingingDamage += 2;
                    MaterialType = UpgradeType.Iron;
                    break;
                case (Gold):
                    Damage += 6;
                    Durability += 30;
                    CriticalChance = 15.0;
                    swingingDamage += 3;
                    MaterialType = UpgradeType.Gold;
                    break;
                case (Diamond):
                    Damage += 8;
                    Durability += 40;
                    CriticalChance = 20.0;
                    swingingDamage += 4;
                    MaterialType = UpgradeType.Diamond;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public override string GetDescription()
        {
            switch(MaterialType)
            {
                case UpgradeType.Wood:
                    return "Wooden Sword";
                case UpgradeType.Iron:
                    return "Iron Sword";
                case UpgradeType.Gold:
                    return "Golden Sword";
                case UpgradeType.Diamond:
                    return "Diamond Sword";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public override string GetStats()
        {
            return $"Damage: {Damage}, Durability: {Durability}, Critical Chance: {CriticalChance}%, Swinging Damage: {swingingDamage}";
        }
    }
}
