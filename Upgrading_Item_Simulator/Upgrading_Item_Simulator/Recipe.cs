using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class Recipe
    {
        //private ItemType itemType;
        //private UpgradeType materialType;
        //private AttributeType attributeType;
        public Dictionary<Resource, int> requiredMaterialsItem { get; set; }
        public Dictionary<Resource, int> requiredMaterialsUpgrade { get; set; }
        public Dictionary<Resource, int> requiredMaterialsAttrib{ get; set; }
        // zmiana typow zmiennych
        //public Recipe(ItemType item, UpgradeType material, AttributeType attrib, Dictionary<Resource,int> reqMat)
        //{
        //    itemType = item;
        //    materialType = material;
        //    attributeType = attrib;
        //    requiredMaterials = reqMat;
        //}
        public Recipe(Dictionary<Resource,int> reqMatItem, Dictionary<Resource, int> reqMatUp, Dictionary<Resource, int> reqMatAt)
        {
            requiredMaterialsItem = reqMatItem;
            requiredMaterialsUpgrade = reqMatUp;
            requiredMaterialsAttrib = reqMatAt;
        }
    }
}
