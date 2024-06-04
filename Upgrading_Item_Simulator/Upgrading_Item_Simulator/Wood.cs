using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    internal class Wood : Resource
    {
        //public Wood(double price, int quantity, string name) : base(price, quantity, name)
        //{

        //}
        public override double GetPrice()
        {
            throw new NotImplementedException();
        }
        public override int GetQuantity()
        {
            return quantity;
        }
        public override string GetName()
        {
            throw new NotImplementedException();
        }
    }
}
