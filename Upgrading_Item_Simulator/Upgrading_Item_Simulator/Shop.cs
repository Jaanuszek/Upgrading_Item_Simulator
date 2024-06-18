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
        public Random random = new Random();
        public int UpgradeLevel { get; private set; }
        private int upgradeCost;
     
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
        public int UpgradeCost
        {
            get
            {
                if (UpgradeLevel == 0)
                {
                    upgradeCost = 1000;
                    return upgradeCost;
                }
                else if (UpgradeLevel == 1)
                {
                    upgradeCost = 5000;
                    return upgradeCost;
                }
                else if (UpgradeLevel == 2)
                {
                    upgradeCost = 10000;
                    return upgradeCost;
                }
                else
                {
                    upgradeCost = 0;
                    return upgradeCost;
                }
            }
        }
        public bool UpgradeShop(Player player)
        {
            if (UpgradeLevel < 3)
            {
                if (player.Money > upgradeCost)
                {
                    player.Money -= upgradeCost;
                    UpgradeLevel++;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public Dictionary<Resource, int>? GetResource(string resourceName, int quantity) //dodanie quantity i zmiana zwracanego typu
        {
            Dictionary <Resource, int> SelledItems = new Dictionary<Resource, int>
            {
                { new Wood(),0 },
                { new Iron(),0 },
                { new Gold(),0 },
                { new Diamond(),0 }
            };
            Resource? resourceToBuy = null;
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
                    SelledItems[resourceToBuy] = 0; //dodanie tego, żeby nie było null w przypadku, gdy nie ma wystarczającej ilości surowca
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
                    switch (UpgradeLevel)
                    {
                        case 1:
                            AvailableResources[resource] = random.Next(5, 25);
                            break;
                        case 2:
                            AvailableResources[resource] = random.Next(10, 30);
                            break;
                        case 3:
                            AvailableResources[resource] = random.Next(20, 35);
                            break;
                        default:
                            AvailableResources[resource] = random.Next(1, 20);
                            break;
                    }
                }
                if (resource is Iron)
                {
                    switch (UpgradeLevel)
                    {
                        case 1:
                            AvailableResources[resource] = random.Next(5, 20);
                            break;
                        case 2:
                            AvailableResources[resource] = random.Next(10, 25);
                            break;
                        case 3:
                            AvailableResources[resource] = random.Next(15, 30);
                            break;
                        default:
                            AvailableResources[resource] = random.Next(1, 15);
                            break;
                    }
                }
                if (resource is Gold)
                {
                    switch (UpgradeLevel)
                    {
                        case 1:
                            AvailableResources[resource] = random.Next(1, 3);
                            break;
                        case 2:
                            AvailableResources[resource] = random.Next(2, 7);
                            break;
                        case 3:
                            AvailableResources[resource] = random.Next(3, 10); 
                            break;
                        default:
                            AvailableResources[resource] = random.Next(0, 3); 
                            break;
                    }
                }
                if (resource is Diamond)
                {
                    switch (UpgradeLevel)
                    {
                        case 1:
                            AvailableResources[resource] = random.Next(1, 3);
                            break;
                        case 2:
                            AvailableResources[resource] = random.Next(2, 6);
                            break;
                        case 3:
                            AvailableResources[resource] = random.Next(5, 11);
                            break;
                        default:
                            AvailableResources[resource] = random.Next(0, 2);
                            break;
                    }
                }
            }
        }
        public void ShowResources() 
        {
            foreach (var resource in AvailableResources)
            {
                Console.WriteLine(resource.Key.GetName() + " " + resource.Value + " " + "Price: " + resource.Key.GetPrice());
            }
        }
    }
}
