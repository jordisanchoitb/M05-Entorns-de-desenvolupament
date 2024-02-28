using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Food: AItem, IMenu
    {
        public int PreparationTime { get; set; }
        public int Type { get; set; }

        public Food(string name, string description, double price, bool onSpecial, int quantity, int preparationTime, int type) : base(name, description, price, onSpecial, quantity)
        {
            PreparationTime = preparationTime;
            Type = type;
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

        public int CalculateTimeCooking(int type)
        {
            switch (type)
            {
                case 0:
                    return 0;
                case 1:
                    return 10;
                case 2:
                    return 20;
                case 3:
                    return 30;
                default:
                    return 0;
            }
        }
    }
}
