using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class Diamond : Resource
    {
        public override double GetPrice()
        {
            return 20 * quantity;
        }
        public override int GetQuantity()
        {
            return quantity;
        }
        public override string GetName()
        {
            return "Diamond";
        }
    }
}
