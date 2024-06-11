using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class Wood : Resource
    {

        public override double GetPrice()
        {
            return 2.5;
        }

        public override string GetName()
        {
            return "Wood";
        }
    }
}
