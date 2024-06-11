using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    abstract class ItemDecorator : Item
    {
        protected Item decoratedItem;
        public ItemDecorator(Item item)
        {
            decoratedItem = item;
            this.Durability = item.Durability;
            this.ItType = item.ItType;
            this.MaterialType = item.MaterialType;
            this.AttribType = item.AttribType;
        }
        public override void Upgrade(Resource resource)
        {
            decoratedItem.Upgrade(resource);
        }
        public override string GetDescription()
        {
            return decoratedItem.GetDescription();
        }
        public override string GetStats()
        {
            return decoratedItem.GetStats();
        }

    }
}
