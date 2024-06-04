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

        }
        public void DisplayAvailableResources(Player player)
        {
            Console.WriteLine("Available resources:");
        }
        public Item CreateItem()
        {
            return null;
        }
        public void ProcessCraftedItem(Customer customerOrder, Item item)
        {

        }
        public void CheckBankruptcy(Player player)
        {
            if(player.money < 0)
            {
                Console.WriteLine("You are bankrupt!");
                return;
            }
        }
    }
}
