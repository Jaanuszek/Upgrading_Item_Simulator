using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    class Player
    {
        public double money { get; private set; }
        public Dictionary<Resource, int> resources { get; private set; }
        public Player(double startingMoney)
        {
            money = startingMoney;
            //resources = new Dictionary<Resource, int>();
        }
        public void BuyResource(Shop shop)
        {

        }
        public IItem CraftItem(string itemType, UpgradeType matType, AttributeType attribType, Recipe recipe)
        {
            return null;
        }
    }
}
