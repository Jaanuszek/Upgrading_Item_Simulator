using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    class Shop
    {
        private List<Resource> AvailableResources;
        public Shop()
        {
            AvailableResources = new List<Resource>();
        }
        public Resource GetResource(string resourceName)
        {
            return AvailableResources.FirstOrDefault(resource => resource.GetName() == resourceName);
        }
        public void RestockResource()
        {
            
        }
    }
}
