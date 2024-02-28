using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Beverage: AItem, IMenu
    {
        public double Size { get; set; }
        public bool WithIce { get; set; }

        public Beverage(string name, string description, double price, bool onSpecial, int quantity, double size, bool withIce) : base(name, description, price, onSpecial, quantity)
        {
            Size = size;
            WithIce = withIce;
        }

        public void AddItem()
        {
            throw new NotImplementedException();
            // no entec que ha de fer aquest mètode
        }

        public override void UpdateInventory(int quantity)
        {
            Quantity += quantity;
        }

        public override string ToString()
        {
            return " Size: " + Size + " With ice: " + WithIce;
        }
    }
}
