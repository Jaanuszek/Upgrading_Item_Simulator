using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class Recipe
    {
        private string itemType;
        private string materialType;
        private string attributeType;
        private Dictionary<Resource, int> requiredMaterials;
        public Recipe(string item, string material, string attrib, Dictionary<Resource,int> reqMat)
        {
            itemType = item;
            materialType = material;
            attributeType = attrib;
            requiredMaterials = reqMat;
        }
    }
}
