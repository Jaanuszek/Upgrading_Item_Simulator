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
        public Order CreateOrder(IItem item, UpgradeType whatMaterial, AttributeType attribType)
        {
            // Create order
            return new Order(item, whatMaterial, attribType);
        }
    }
}
