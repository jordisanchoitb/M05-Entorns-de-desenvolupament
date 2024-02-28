using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public abstract class AItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool OnSpecial { get; set; }
        public int Quantity { get; set; }

        public AItem(string name, string description, double price, bool onSpecial, int quantity)
        {
            Name = name;
            Description = description;
            Price = price;
            OnSpecial = onSpecial;
            Quantity = quantity;
        }

        public abstract void UpdateInventory(int quantity);
    }
}
