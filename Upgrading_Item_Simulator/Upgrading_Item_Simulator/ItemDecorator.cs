using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    abstract class ItemDecorator : IItem
    {
        protected IItem decoratedItem;
        public ItemDecorator(IItem item)
        {
            decoratedItem = item;
        }

    }
}
