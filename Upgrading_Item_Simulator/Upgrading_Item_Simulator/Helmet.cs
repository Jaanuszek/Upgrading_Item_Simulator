﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class Helmet : Armor
    {
        public override void Upgrade(Resource resource)
        {
            throw new NotImplementedException();
        }
        public override string GetDescription()
        {
            return "Helmet";
        }
        public override string GetStats()
        {
            throw new NotImplementedException();
        }
    }
}
