using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    class GameEngine
    {
        private Shop shop;
        private Player player;
        private IRecipeFactory recipe;
        public GameEngine(Shop shop, Player player)
        {
            this.shop = shop;
            this.player = player;
        }
        public void RunGame()
        {
            bool running = CheckBankruptcy(player);
            Console.WriteLine("Welcome to the Upgrading Items simulator!");
            Console.WriteLine("You can buy resources in the shop and craft items with them.");
            Console.WriteLine("Rules are simple: you can't go bankrupt.\nFirstly you go to the shop to buy resources" +
                ",then you have to remember the recipe of this item and you have to forge it\nvery simple right?");
            while (running)
            {
                Customer customer = new Customer("Zbigniew");
                Order order = customer.CreateOrder();
                IRecipeFactory recipeFactory = new RecipeFactory();
                Recipe recipe = recipeFactory.CreateRecipe(order);
                Console.WriteLine("Create the following item:");
                Console.WriteLine(order.GetValues());
                Console.WriteLine("You have to use the following resources:");
                recipe.ShowRecipe();
                shop.RestockResource();
                Console.WriteLine("Your Resources:");
                foreach (var resource in player.Resources)
                {
                    Console.WriteLine(resource.Key.GetName() + " " + resource.Value);
                }
                Console.WriteLine($"You have {player.Money} money");
                Console.WriteLine("Available resources in shop:");
                shop.ShowResources();
                player.BuyResource(shop);
                Item craftedItem = CreateItem();
                player.Money += ProcessCraftedItem(order, craftedItem);
                Console.WriteLine($"You have {player.Money} money");
                running = CheckBankruptcy(player);
            }
        }
        //usunięta metoda ShowResources
        public Item CreateItem()
        {
            ItemType itType;
            UpgradeType matType;
            AttributeType attType;
            ItemType[] itemTypes = new ItemType[]
{
                ItemType.None,
                ItemType.Dagger,
                ItemType.Sword,
                ItemType.Axe,
                ItemType.Bow,
                ItemType.Chestplate,
                ItemType.Helmet,
                ItemType.Boots
            };
            UpgradeType[] upgradeTypes = new UpgradeType[]
            {
                UpgradeType.None,
                UpgradeType.Wood,
                UpgradeType.Iron,
                UpgradeType.Gold,
                UpgradeType.Diamond
            };
            AttributeType[] attributeTypes = new AttributeType[]
            {
                AttributeType.Fire,
                AttributeType.Ice,
                AttributeType.Poison
            };
            Console.WriteLine("What item do you want to create?");
            Console.WriteLine("1. Dagger\n2. Sword\n3. Axe\n4. Bow\n5. Chestplate\n6. Helmet\n7. Boots"); //DODAC MOZLIWOSC ZREZYGNOWANIA Z TWORZENIA PRZEDMIOTU
            int choice = Convert.ToInt32(Console.ReadLine());
            itType = (choice>=1 && choice <= 7) ? itemTypes[choice] : ItemType.None;
            Console.WriteLine("What material do you want to use?");
            Console.WriteLine("1. Wood\n2. Iron\n3. Gold\n4. Diamond");
            choice = Convert.ToInt32(Console.ReadLine());
            matType = (choice >= 1 && choice <= 4) ? upgradeTypes[choice] : UpgradeType.None;
            Console.WriteLine("What attribute do you want to add?");
            Console.WriteLine("1. Fire\n2. Ice\n3. Poison\n4. None");
            choice = Convert.ToInt32(Console.ReadLine());
            attType = (choice >= 1 && choice <= 3) ? attributeTypes[choice-1] : AttributeType.None;
            return player.CraftItem(itType, matType, attType);
        }
        public double ProcessCraftedItem(Order customerOrder, Item craftedItem) //zamiana na obiekt typu Order zmiana typu funkcji na double
        {
            double result = 0;
            if(customerOrder.item == craftedItem.ItType)
            {
                Console.WriteLine("You have crafted the correct item type!");
            }
            else
            {
                Console.WriteLine("You have crafted the wrong item type!\nYou lose 50 credits!");
                return -50;
            }
            if(customerOrder.upgradeType == craftedItem.MaterialType)
            {
                Console.WriteLine("You have used the correct material!");
                result += 100;
            }
            else
            {
                Console.WriteLine("You have used the wrong material!\n");
                return 50;
            }
            if(customerOrder.attributeType == craftedItem.AttribType)
            {
                Console.WriteLine("You have added the correct attribute!");
                result += 100;
            }
            else
            {
                Console.WriteLine("You have added the wrong attribute!\n");
                return 100;
            }
            return result;
        }
        public bool CheckBankruptcy(Player player) //zmiana na bool
        {
            if(player.Money < 0)
            {
                Console.WriteLine("You are bankrupt!");
                return false;
            }
            return true;
        }
    }
}
