using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class Axe : Weapon
    {
        private double cleaveRange { get; set; } //zasieg cięcia
        public Axe():base()
        {
            ItType = ItemType.Axe;
            cleaveRange = 1;
        }
        public override void Upgrade(Resource resource)
        {
            switch (resource)
            {
                case (Wood):
                    Damage += 2;
                    Durability += 3;
                    CriticalChance = 10.0;
                    cleaveRange = 2;
                    MaterialType = UpgradeType.Wood;
                    break;
                case (Iron):
                    Damage += 4;
                    Durability += 5;
                    CriticalChance = 20.0;
                    cleaveRange = 3;
                    MaterialType = UpgradeType.Iron;
                    break;
                case (Gold):
                    Damage += 6;
                    Durability += 7;
                    CriticalChance = 30.0;
                    cleaveRange = 4;
                    MaterialType = UpgradeType.Gold;
                    break;
                case (Diamond):
                    Damage += 8;
                    Durability += 9;
                    CriticalChance = 40.0;
                    cleaveRange = 5;
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
                    return "Wooden Axe";
                case UpgradeType.Iron:
                    return "Iron Axe";
                case UpgradeType.Gold:
                    return "Golden Axe";
                case UpgradeType.Diamond:
                    return "Diamond Axe";
                default:
                    return "Axe";
            }
        }
        public override string GetStats()
        {
            return $"Damage: {Damage},\nDurability: {Durability},\nCritical Chance: {CriticalChance}%,\nCleave Range:\n{cleaveRange}%";
        }
    }
}
