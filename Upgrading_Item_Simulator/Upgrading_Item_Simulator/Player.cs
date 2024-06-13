using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    class Player
    {
        public double Money { get; set; }
        public Dictionary<Resource, int> Resources { get; set; }
        public Player(double startingMoney)
        {
            Money = startingMoney;
            Resources = new Dictionary<Resource, int>
            {
                {new Wood(), 10},
                {new Iron(), 10},
                {new Gold(), 10},
                {new Diamond(), 10}
            };
        }
        public void BuyResource(Shop shop)
        {
            bool isBuying = true;
            while (isBuying)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                ShowInventory();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Remaining money: " + Money);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("What resource do you want to buy?");
                Console.WriteLine("1. Wood \n2. Iron\n3. Gold\n4. Diamond\n");
                Console.WriteLine("if you want to stop buying type 'stop'");
                string resourceName = Console.ReadLine() ?? string.Empty;
                //operator ?? to null-coalescing ustawia domyślną wartość w przypadku gdyby ten ReadLine() zwrocił null
                if(string.IsNullOrEmpty(resourceName))
                {
                    Console.WriteLine("Wrong input");
                    continue;
                }
                if (resourceName.ToLower() == "stop")
                {
                    isBuying = false;
                    break;
                }
                else if( resourceName != "1" && resourceName != "2" && resourceName != "3" && resourceName != "4")
                {
                    Console.WriteLine("Wrong input");
                    continue;
                }
                int quantity = 0;
                Resource? resourceToBuy = null; //? oznacza, że zmienna może być nullem
                switch (resourceName)
                {
                    case ("1"):
                        resourceToBuy = new Wood();
                        Console.WriteLine("How much wood do you want to buy?");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        Wood wood = new Wood();
                        break;
                    case ("2"):
                        resourceToBuy = new Iron();
                        Console.WriteLine("How much iron do you want to buy?");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        break;
                    case ("3"):
                        resourceToBuy = new Gold();
                        Console.WriteLine("How much gold do you want to buy?");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        break;
                    case ("4"):
                        resourceToBuy = new Diamond();
                        Console.WriteLine("How much diamond do you want to buy?");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        break;
                }
                if (resourceToBuy != null)
                {
                    var boughtResources = shop.GetResource(resourceToBuy.GetName(), quantity);
                    double totalCost = resourceToBuy.GetPrice() * quantity;
                    if (Money >= totalCost)
                    {

                        if (boughtResources != null)
                        {
                            if (boughtResources[resourceToBuy] == 0)
                            {
                                Console.WriteLine("Not enough resources");
                            }
                            else
                            {
                                Money -= totalCost;
                                AddResource(boughtResources, quantity);
                                Console.WriteLine($"You bought {quantity} {resourceToBuy.GetName()} for {totalCost}. Remaining money: {Money}");
                            }
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            ShowInventory();
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money to buy these resources");
                        Console.WriteLine($"Remaining money {Money}");
                    }
                }
                Console.Clear();
                Console.WriteLine("Shop Resources:");
                shop.ShowResources();
            }
            Console.Clear();
        }
        private void AddResource(Dictionary<Resource,int> resourcesToAdd, int quantity)
        {
            foreach(var resource in resourcesToAdd)
            {
                Resources[resource.Key] += resource.Value;
            }
        }
        public void ShowInventory()
        {
            Console.WriteLine("Your inventory:");
            foreach (var res in Resources)
            {
                Console.WriteLine(res.Key.GetName() + " " + res.Value);
            }
        }
        public Item? CraftItem(ItemType itemType, UpgradeType matType, AttributeType attribType) //usuniecie argumentu Recipe
        {
            if(itemType == ItemType.None)
            {
                return null;
            }
            IRecipeFactory recipeFactory = new RecipeFactory();
            Recipe recipe = recipeFactory.CreateRecipe(itemType,matType,attribType);
            foreach(var resource in recipe.requiredMaterialsItem)
            {
                if (Resources[resource.Key] < resource.Value)
                {
                    Console.WriteLine("You don't have enough resources to craft this item");
                    return null;
                }
                Resources[resource.Key] -= resource.Value;
            }
            Item item = CreateItem(itemType);
            if (matType != UpgradeType.None)
            {
                Resource material = CreateMaterial(matType);
                foreach (var resource in recipe.requiredMaterialsUpgrade)
                {
                    if (Resources[resource.Key] < resource.Value)
                    {
                        Console.WriteLine("You don't have enough resources to upgrade this item");
                        return item;
                    }
                    Resources[resource.Key] -= resource.Value;
                }
                item.Upgrade(material);
            }
            foreach(var resource in recipe.requiredMaterialsAttrib)
            {
                if (Resources[resource.Key] < resource.Value)
                {
                    Console.WriteLine("You don't have enough resources to add attribute to this item");
                    return item;
                }
                Resources[resource.Key] -= resource.Value;
            }
            item = AddAttribute(item, attribType);
            return item;
        }

        //te metody mozna do oddzielnej klasy w sumie wrzucic, żeby bylo bardziej modularnie
        // ZASTANOWIC SIE CO Z TYM ZROBIC
        private static Item CreateItem(ItemType itemType)
        {
            return itemType switch
            {
                ItemType.Dagger => new Dagger(),
                ItemType.Sword => new Sword(),
                ItemType.Axe => new Axe(),
                ItemType.Bow => new Bow(),
                ItemType.Chestplate => new Chestplate(),
                ItemType.Helmet => new Helmet(),
                ItemType.Boots => new Boots(),
                _ => throw new ArgumentException("Invalid item type")
            }; 
        }
        private static Resource CreateMaterial(UpgradeType matType)
        {
            return matType switch
            {
                UpgradeType.Wood => new Wood(),
                UpgradeType.Iron => new Iron(),
                UpgradeType.Gold => new Gold(),
                UpgradeType.Diamond => new Diamond(),
                _ => throw new ArgumentException("Invalid material type")
            };
        }
        private static Item AddAttribute(Item item, AttributeType attribType)
        {
            return attribType switch
            {
                AttributeType.Fire => new FireDecorator(item),
                AttributeType.Ice => new IceDecorator(item),
                AttributeType.Poison => new PoisonDecorator(item),
                AttributeType.None => item,
                _ => throw new ArgumentException("Invalid attribute type")
            };
        }
    }
}
