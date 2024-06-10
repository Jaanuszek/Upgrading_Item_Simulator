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
            cleaveRange = 0;
        }
        public override void Upgrade(Resource resource)
        {
            switch (resource)
            {
                case (Wood):
                    Damage += 1;
                    Durability += 1;
                    CriticalChance = 5.0;
                    cleaveRange = 1;
                    MaterialType = UpgradeType.Wood;
                    break;
                case (Iron):
                    Damage += 2;
                    Durability += 2;
                    CriticalChance = 30.0;
                    cleaveRange = 2;
                    MaterialType = UpgradeType.Iron;
                    break;
                case (Gold):
                    Damage += 3;
                    Durability += 3;
                    CriticalChance = 50.0;
                    cleaveRange = 3;
                    MaterialType = UpgradeType.Gold;
                    break;
                case (Diamond):
                    Damage += 4;
                    Durability += 4;
                    CriticalChance = 70.0;
                    cleaveRange = 4;
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
                    throw new ArgumentOutOfRangeException();
            }
        }
        public override string GetStats()
        {
            return $"Damage: {Damage}, Durability: {Durability}, Critical Chance: {CriticalChance}%, Cleave Range: {cleaveRange}%";
        }
    }
}
