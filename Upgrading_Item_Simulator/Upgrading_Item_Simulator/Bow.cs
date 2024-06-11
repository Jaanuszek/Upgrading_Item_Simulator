using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class Bow : Weapon
    {
        private double range { get; set; }
        public Bow(): base()
        {
            range = 0;
            ItType = ItemType.Bow;
        }
        public override void Upgrade(Resource resource)
        {
            switch (resource)
            {
                case (Wood):
                    Damage += 2;
                    Durability += 2;
                    CriticalChance = 10.0;
                    range = 15;
                    MaterialType = UpgradeType.Wood;
                    break;
                case (Iron):
                    Damage += 4;
                    Durability += 4;
                    CriticalChance = 20.0;
                    range = 25;
                    MaterialType = UpgradeType.Iron;
                    break;
                case (Gold):
                    Damage += 6;
                    Durability += 6;
                    CriticalChance = 30.0;
                    range = 35;
                    MaterialType = UpgradeType.Gold;
                    break;
                case (Diamond):
                    Damage += 8;
                    Durability += 8;
                    CriticalChance = 40.0;
                    range = 45;
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
                    return "Wooden Bow";
                case UpgradeType.Iron:
                    return "Iron Bow";
                case UpgradeType.Gold:
                    return "Golden Bow";
                case UpgradeType.Diamond:
                    return "Diamond Bow";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public override string GetStats()
        {
            return $"Damage: {Damage},\nDurability: {Durability},\nCritical Chance: {CriticalChance}%,\nRange: {range}m";
        }
    }
}
