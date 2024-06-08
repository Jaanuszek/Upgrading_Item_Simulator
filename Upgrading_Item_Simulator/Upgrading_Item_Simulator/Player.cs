using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    class Player
    {
        public double Money { get; private set; }
        public Dictionary<Resource, int> Resources { get; private set; }
        public Player(double startingMoney)
        {
            Money = startingMoney;
            Resources = new Dictionary<Resource, int>
            {
                {new Wood(), 0},
                {new Iron(), 0},
                {new Gold(), 0},
                {new Diamond(), 0}
            };
        }
        public void BuyResource(Shop shop)
        {
            bool isBuying = true;
            Dictionary<Resource,int> BoughtResources = new Dictionary<Resource, int>();
            while (isBuying)
            {
                Console.WriteLine("What resource do you want to buy?");
                Console.WriteLine("1. Wood \n2. Iron\n3. Gold\n4. Diamond\n");
                Console.WriteLine("if you want to stop buying type 'stop'");
                string resourceName = Console.ReadLine();
                if (resourceName == "stop")
                {
                    isBuying = false;
                    break;
                }
                else if( resourceName != "1" && resourceName != "2" && resourceName != "3" && resourceName != "4")
                {
                    Console.WriteLine("Wrong input");
                    continue;
                }
                switch (resourceName)
                {
                    case ("1"):
                        Console.WriteLine("How much wood do you want to buy?");
                        int qunatity = Convert.ToInt32(Console.ReadLine());
                        BoughtResources = shop.GetResource("Wood", qunatity);
                        //foreach (Resource resource in BoughtResources.Keys)
                        //{
                        //    if (resource.GetName() == "Wood")
                        //    {
                        //        //money -= resource.GetPrice() * qunatity;
                        //        Resources[resource] += qunatity;
                        //    }
                        //}
                        break;
                    case ("2"):
                        Console.WriteLine("How much iron do you want to buy?");
                        qunatity = Convert.ToInt32(Console.ReadLine());
                        BoughtResources = shop.GetResource("Iron", qunatity);
                        break;
                    case ("3"):
                        Console.WriteLine("How much gold do you want to buy?");
                        qunatity = Convert.ToInt32(Console.ReadLine());
                        BoughtResources = shop.GetResource("Gold", qunatity);
                        break;
                    case ("4"):
                        Console.WriteLine("How much diamond do you want to buy?");
                        qunatity = Convert.ToInt32(Console.ReadLine());
                        BoughtResources = shop.GetResource("Diamond", qunatity);
                        break;
                    default:
                        break;
                }
            }
        }
        public Item CraftItem(string itemType, UpgradeType matType, AttributeType attribType, Recipe recipe)
        {
            return null;
        }
    }
}
