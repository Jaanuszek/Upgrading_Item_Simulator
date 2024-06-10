using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class Gold : Resource
    {
        public override double GetPrice()
        {
            return 30;
        }
        public override int GetQuantity()
        {
            return quantity;
        }
        public override string GetName()
        {
            return "Gold";
        }

    }
}
