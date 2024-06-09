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

        public override bool Equals(object? obj) //Metoda sprawdzająca czy porównywalny obiekt ma takie same właściwości
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Resource other = (Resource)obj;
            return this.name == other.name;
        }
        // Metoda która wypisuje ten sam HashCode dla obiektów o takich samych właściwościach
        public override int GetHashCode() 
        {
            return name == null ? 0 : name.GetHashCode();
        }
        abstract public double GetPrice();
        abstract public int GetQuantity();
        abstract public string GetName();
    }
}
