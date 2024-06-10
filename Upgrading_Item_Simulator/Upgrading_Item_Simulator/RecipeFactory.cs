using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    class RecipeFactory : IRecipeFactory
    {
        public Recipe CreateRecipe(Order order)
        {
            return CreateRecipe(order.item, order.upgradeType, order.attributeType);
        }
        public Recipe CreateRecipe(Item item)
        {
            return CreateRecipe(item.ItType, item.MaterialType, item.AttribType);
        }
        public Recipe CreateRecipe(ItemType itemType, UpgradeType materialType, AttributeType attributeType)
        {
            Dictionary<Resource, int> requiredMaterialsItem = new Dictionary<Resource, int>();
            Dictionary<Resource, int> requiredMaterialsUpgrade = new Dictionary<Resource, int>();
            Dictionary<Resource, int> requiredMaterialsAttrib = new Dictionary<Resource, int>();

            switch (itemType)
            {
                case ItemType.Dagger:
                    requiredMaterialsItem.Add(new Iron(), 1);
                    requiredMaterialsItem.Add(new Wood(), 2);
                    break;
                case ItemType.Sword:
                    requiredMaterialsItem.Add(new Iron(), 2);
                    requiredMaterialsItem.Add(new Wood(), 2);
                    break;
                case ItemType.Axe:
                    requiredMaterialsItem.Add(new Iron(), 3);
                    requiredMaterialsItem.Add(new Wood(), 2);
                    break;
                case ItemType.Bow:
                    requiredMaterialsItem.Add(new Iron(), 2);
                    requiredMaterialsItem.Add(new Wood(), 3);
                    break;
                case ItemType.Chestplate:
                    requiredMaterialsItem.Add(new Iron(), 5);
                    requiredMaterialsItem.Add(new Wood(), 3);
                    break;
                case ItemType.Helmet:
                    requiredMaterialsItem.Add(new Iron(), 3);
                    requiredMaterialsItem.Add(new Wood(), 2);
                    break;
                case ItemType.Boots:
                    requiredMaterialsItem.Add(new Iron(), 2);
                    requiredMaterialsItem.Add(new Wood(), 1);
                    break;
                case ItemType.None:
                    break;
            }

            switch(materialType)
            {
                case UpgradeType.Wood:
                    requiredMaterialsUpgrade.Add(new Wood(), 1);
                    break;
                case UpgradeType.Iron:
                    requiredMaterialsUpgrade.Add(new Iron(), 1);
                    break;
                case UpgradeType.Gold:
                    requiredMaterialsUpgrade.Add(new Gold(), 1);
                    break;
                case UpgradeType.Diamond:
                    requiredMaterialsUpgrade.Add(new Diamond(), 1);
                    break;
                case UpgradeType.None:
                    break;
            }

            switch(attributeType)
            {
                case AttributeType.Fire:
                    requiredMaterialsAttrib.Add(new Diamond(), 3);
                    requiredMaterialsAttrib.Add(new Wood(), 5);
                    break;
                case AttributeType.Ice:
                    requiredMaterialsAttrib.Add(new Gold(), 4);
                    break;
                case AttributeType.Poison:
                    requiredMaterialsAttrib.Add(new Iron(), 5);
                    requiredMaterialsAttrib.Add(new Diamond(), 1);
                    break;
                case AttributeType.None:
                    break;
            }

            return new Recipe(requiredMaterialsItem, requiredMaterialsUpgrade, requiredMaterialsAttrib);
        }
    }
}
