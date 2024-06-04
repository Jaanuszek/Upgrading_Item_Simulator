using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class Helmet : Armor
    {
        public override void Upgrade(Resource resource)
        {
            switch (resource)
            {
                case (Wood):
                    Durability += 1;
                    armorValue += 1;
                    chanceToBlock = 5.0;
                    elemetsResistance = 5.0;
                    MaterialType = UpgradeType.Wood;
                    break;
                case (Iron):
                    Durability += 2;
                    armorValue += 2;
                    chanceToBlock = 10.0;
                    elemetsResistance = 10.0;
                    MaterialType = UpgradeType.Iron;
                    break;
                case (Gold):
                    Durability += 3;
                    armorValue += 3;
                    chanceToBlock = 15.0;
                    elemetsResistance = 15.0;
                    MaterialType = UpgradeType.Gold;
                    break;
                case (Diamond):
                    Durability += 4;
                    armorValue += 4;
                    chanceToBlock = 20.0;
                    elemetsResistance = 20.0;
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
                case(UpgradeType.Wood):
                    return "Wooden Helmet";
                case (UpgradeType.Iron):
                    return "Iron Helmet";
                case (UpgradeType.Gold):
                    return "Golden Helmet";
                case (UpgradeType.Diamond):
                    return "Diamond Helmet";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public override string GetStats()
        {
            return $"Durability: {Durability}\nArmor Value: {armorValue}\nChance to block: {chanceToBlock}%\nElements Resistance: {elemetsResistance}%";
        }
    }
}
