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
        public Dictionary<Resource, int> SelledItems { get; set; }
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
            SelledItems = new Dictionary<Resource, int>
            {
                { new Wood(),0 },
                { new Iron(),0 },
                { new Gold(),0 },
                { new Diamond(),0 }
            };
        }
        public Dictionary<Resource,int> GetResource(string resourceName, int quantity) //dodanie quantity i zmiana zwracanego typu
        {
            //ogarnąć tę metodę
            foreach (Resource resource in AvailableResources.Keys)
            {
                if (resource.GetName() == resourceName)
                {
                    if (AvailableResources[resource] >= quantity)
                    {
                        if(SelledItems.ContainsKey(resource))
                        {
                            SelledItems[resource] += quantity;
                        }
                        else
                        {
                            SelledItems[resource] = quantity;
                        }
                        AvailableResources[resource] -= quantity;
                        return SelledItems;
                    }
                    else if (AvailableResources[resource] < quantity) // w tym przypadku kupuje tyle ile jest dostepne
                    {
                        int temp = AvailableResources[resource];
                        SelledItems[resource] += temp;
                        AvailableResources[resource] = 0;
                        return SelledItems;
                    }
                    else
                    {
                        Console.WriteLine("There is not enough resources in the shop!");
                        return SelledItems;
                    }
                }
            }
            return SelledItems;
        }
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
