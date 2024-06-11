using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class Iron : Resource
    {
        public override double GetPrice()
        {
            return 10;
        }

        public override string GetName()
        {
            return "Iron";
        }
    }
}
