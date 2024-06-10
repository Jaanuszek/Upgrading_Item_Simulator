using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    interface IRecipeFactory
    {
        Recipe CreateRecipe(Order order);
        Recipe CreateRecipe(Item item);
        Recipe CreateRecipe(ItemType itemType, UpgradeType materialType, AttributeType attributeType);
    }
}
