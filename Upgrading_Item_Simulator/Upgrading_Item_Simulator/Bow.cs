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
                    Damage += 1;
                    Durability += 1;
                    CriticalChance = 5.0;
                    range = 10;
                    MaterialType = UpgradeType.Wood;
                    break;
                case (Iron):
                    Damage += 2;
                    Durability += 2;
                    CriticalChance = 30.0;
                    range = 20;
                    MaterialType = UpgradeType.Iron;
                    break;
                case (Gold):
                    Damage += 3;
                    Durability += 3;
                    CriticalChance = 50.0;
                    range = 30;
                    MaterialType = UpgradeType.Gold;
                    break;
                case (Diamond):
                    Damage += 4;
                    Durability += 4;
                    CriticalChance = 70.0;
                    range = 40;
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
            return $"Damage: {Damage}, Durability: {Durability}, Critical Chance: {CriticalChance}%, Range: {range}m";
        }
    }
}
