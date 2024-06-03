using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class FireDecorator : ItemDecorator   
    {
        public FireDecorator(IItem item) : base(item)
        {

        }
    }
}
