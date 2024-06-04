using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class Boots : Armor
    {
        public override void Upgrade(Resource resource)
        {
            throw new NotImplementedException();
        }
        public override string GetDescription()
        {
            return "Boots";
        }
        public override string GetStats()
        {
            throw new NotImplementedException();
        }
    }
}
