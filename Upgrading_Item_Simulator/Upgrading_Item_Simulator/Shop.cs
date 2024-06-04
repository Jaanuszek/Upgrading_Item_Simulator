using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    class Shop
    {
        private Dictionary<Resource,int> AvailableResources;
        public Shop()
        {
            AvailableResources = new Dictionary<Resource, int>();
        }
        public Resource GetResource(string resourceName)
        {
            return null;
        }
        public void RestockResource()
        {
            
        }
    }
}
