using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class Dagger:Weapon
    {
        private double backStabChance { get; set; }
        public Dagger() : base()
        {
            backStabChance = 0.0;
            MaterialType = UpgradeType.None;
        }
        public override void Upgrade(Resource resource)
        {
            Random rnd = new Random();
            switch (resource)
            {
                case Wood:
                    Damage += 1;
                    Durability += 1;
                    CriticalChance = 5.0;
                    backStabChance = Math.Round(rnd.NextDouble()*10,2);
                    MaterialType = UpgradeType.Wood;
                    break;
                case Iron:
                    Damage += 2;
                    Durability += 2;
                    CriticalChance = 30.0;
                    backStabChance = Math.Round(rnd.NextDouble() * 20, 2);
                    MaterialType = UpgradeType.Iron;
                    break;
                case Gold:
                    Damage += 3;
                    Durability += 3;
                    CriticalChance = 50.0;
                    backStabChance = Math.Round(rnd.NextDouble() * 30, 2);
                    MaterialType = UpgradeType.Gold;
                    break;
                case Diamond:
                    Damage += 4;
                    Durability += 4;
                    CriticalChance = 70.0;
                    backStabChance = Math.Round(rnd.NextDouble() * 50, 2);
                    MaterialType = UpgradeType.Diamond;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();

            }
        }
        public override string GetDescription()
        {
            switch (MaterialType)
            {
                case UpgradeType.Wood:
                    return "Wooden Dagger";
                case UpgradeType.Iron:
                    return "Iron Dagger";
                case UpgradeType.Gold:
                    return "Golden Dagger";
                case UpgradeType.Diamond:
                    return "Diamond Dagger";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public override string GetStats()
        {
            return $"Damage: {Damage}, Durability: {Durability}, Critical Chance: {CriticalChance}%, Backstab Chance: {backStabChance}%";
        }
    }
}
