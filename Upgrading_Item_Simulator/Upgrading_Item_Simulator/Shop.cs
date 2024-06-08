using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    class Shop
    {
        public Dictionary<Resource,int> AvailableResources { get; set; }
        Random random = new Random(); //dodanie tego
        public Shop()
        {
            AvailableResources = new Dictionary<Resource, int>
            {
                { new Wood(),0 },
                { new Iron(),0 },
                { new Gold(),0 },
                { new Diamond(),0 }
            };
        }
        public Dictionary<Resource, int> GetResource(string resourceName, int quantity) //dodanie quantity i zmiana zwracanego typu
        {
            Dictionary <Resource, int> SelledItems = new Dictionary<Resource, int>
            {
                { new Wood(),0 },
                { new Iron(),0 },
                { new Gold(),0 },
                { new Diamond(),0 }
            };
            foreach (Resource res in AvailableResources.Keys)
            {
                if(res.GetName() == resourceName)
                {
                    if (AvailableResources[res] >= quantity)
                    {
                        AvailableResources[res] -= quantity;
                        SelledItems[res] += quantity;
                        return new Dictionary<Resource, int> { { res, quantity } };
                    }
                    else
                    {
                        Console.WriteLine("Not enough resources");
                        return null;
                    }
                }
            }
            return new Dictionary<Resource, int>();
        }
        //private Resource GetResourceByName(string resourceName)
        //{
        //    foreach (var resource in AvailableResources.Keys)
        //    {
        //        if (resource.GetName() == resourceName)
        //        {
        //            return resource;
        //        }
        //    }
        //    return null;
        //}
        public void RestockResource()
        {
            List<Resource> resources = new List<Resource>(AvailableResources.Keys);
            foreach (Resource resource in resources)
            {
                if (resource is Wood)
                {
                    AvailableResources[resource] = random.Next(1, 20);
                }
                if (resource is Iron)
                {
                    AvailableResources[resource] = random.Next(1, 15);
                }
                if (resource is Gold)
                {
                    AvailableResources[resource] = random.Next(0, 7);
                }
                if (resource is Diamond)
                {
                    AvailableResources[resource] = random.Next(0, 3);
                }
            }
        }
    }
}
