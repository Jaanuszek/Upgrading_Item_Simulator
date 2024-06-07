using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class Customer
    {
        private string name;
        public Customer(string name)
        {
            this.name = name;
        }
        public Order CreateOrder() //zmiana argumentow
        {
            // Create order
            Random rand = new Random();

            Array itemType = Enum.GetValues(typeof(ItemType));
            int randomIndex = rand.Next(itemType.Length-1);
            ItemType it = (ItemType)itemType.GetValue(randomIndex);

            Array valuesUpType = Enum.GetValues(typeof(UpgradeType));
            randomIndex = rand.Next(valuesUpType.Length-1);
            UpgradeType up = (UpgradeType)valuesUpType.GetValue(randomIndex);

            Array valuesAttribType = Enum.GetValues(typeof(AttributeType));
            randomIndex = rand.Next(valuesAttribType.Length);
            AttributeType attrib = (AttributeType)valuesAttribType.GetValue(randomIndex);

            return new Order(it, up, attrib);
        }
    }
}
