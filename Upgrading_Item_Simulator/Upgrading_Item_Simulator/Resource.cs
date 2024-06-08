using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upgrading_Item_Simulator
{
    abstract class Resource
    {
        protected double price { get; set; }
        protected int quantity { get; set; } //mozliwe ze to sie w ogole nie przyda
        protected string name { get; set; }
        //public Resource(double price, int quantity, string name)
        //{
        //    this.price = price;
        //    this.quantity = quantity;
        //    this.name = name;
        //}z
        abstract public double GetPrice();
        abstract public int GetQuantity();
        abstract public string GetName();
    }
}
