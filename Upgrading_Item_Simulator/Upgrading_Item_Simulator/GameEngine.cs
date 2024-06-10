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
                shop.RestockResource();
                Console.WriteLine("Your Resources:");
                foreach (var resource in player.Resources)
                {
                    Console.WriteLine(resource.Key.GetName() + " " + resource.Value);
                }
                Console.WriteLine("Available resources in shop:");
                shop.ShowResources();
                player.BuyResource(shop);

                running = false; //debuggin reasons
            }
        }
        //usunięta metoda ShowResources
        public Item CreateItem()
        {
            return null;
        }
        public void ProcessCraftedItem(Customer customerOrder, Item item)
        {

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
