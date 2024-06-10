using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class Recipe
    {
        public Dictionary<Resource, int> requiredMaterialsItem { get; set; }
        public Dictionary<Resource, int> requiredMaterialsUpgrade { get; set; }
        public Dictionary<Resource, int> requiredMaterialsAttrib{ get; set; }
        // zmiana typow zmiennych
        public Recipe(Dictionary<Resource,int> reqMatItem, Dictionary<Resource, int> reqMatUp, Dictionary<Resource, int> reqMatAt)
        {
            requiredMaterialsItem = reqMatItem;
            requiredMaterialsUpgrade = reqMatUp;
            requiredMaterialsAttrib = reqMatAt;
        }
        public void ShowRecipe()
        {
            Console.WriteLine("To Create Item:");
            foreach (var resource in requiredMaterialsItem)
            {
                Console.WriteLine(resource.Key.GetName() + " " + resource.Value);
            }
            Console.WriteLine("To Upgrade Item:");
            foreach (var resource in requiredMaterialsUpgrade)
            {
                Console.WriteLine(resource.Key.GetName() + " " + resource.Value);
            }
            Console.WriteLine("To Add Attribute:");
            foreach (var resource in requiredMaterialsAttrib)
            {
                Console.WriteLine(resource.Key.GetName() + " " + resource.Value);
            }
        }
    }
}
