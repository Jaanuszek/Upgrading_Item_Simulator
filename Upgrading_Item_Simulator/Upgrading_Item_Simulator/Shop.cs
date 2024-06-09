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
            Resource resourceToBuy = null;
            switch (resourceName.ToLower())
            {
                case "wood":
                    resourceToBuy = new Wood();
                    break;
                case "iron":
                    resourceToBuy = new Iron();
                    break;
                case "gold":
                    resourceToBuy = new Gold();
                    break;
                case "diamond":
                    resourceToBuy = new Diamond();
                    break;
                default:
                    Console.WriteLine("Unknown resource.");
                    return null;
            }
            if (resourceToBuy != null) 
            { 
                if (AvailableResources.TryGetValue(resourceToBuy, out int shopQuantity) && shopQuantity >= quantity)
                {
                    AvailableResources[resourceToBuy] -= quantity;
                    if (SelledItems.ContainsKey(resourceToBuy))
                    {
                        SelledItems[resourceToBuy] += quantity;
                    }
                    else
                    {
                        SelledItems[resourceToBuy] = quantity;
                    }
                }
                else
                {
                    Console.WriteLine("Not enough resources");
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
        public void ShowResources() //nie wiem czy sie przyda, ale narazie niech sobie bedzie
        {
            foreach (var resource in AvailableResources)
            {
                Console.WriteLine(resource.Key.GetName() + " " + resource.Value);
            }
        }
    }
}
