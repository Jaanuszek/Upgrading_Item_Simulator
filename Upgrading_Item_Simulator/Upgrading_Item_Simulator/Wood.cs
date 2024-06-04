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
            throw new NotImplementedException();
        }
        public override int GetQuantity()
        {
            return 1;
        }
        public override string GetName()
        {
            throw new NotImplementedException();
        }
    }
}
