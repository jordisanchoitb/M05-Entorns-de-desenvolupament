/*
 * Author: Jordi Sancho Garcia
 * M03. Programació UF4
 * v1. 5/2/2024
 * 
 * Exercici x. 

 */
using System;

namespace OOPEx
{
    public class Program
    {
        public static void Main()
        {
            Beverage beverage = new Beverage("Coca-cola", "Coca-cola sense sucre", 2.5, false, 10, 0.5, true);
            Food food = new Food("Hamburguesa", "Hamburguesa de vedella", 5, false, 10, 10, 1);

            Console.WriteLine(beverage);
            Console.WriteLine("Quantitat de coca-cola: " + beverage.Quantity);
            beverage.UpdateInventory(5);
            Console.WriteLine("Quantitat de coca-cola: " + beverage.Quantity);

            Console.WriteLine("Quant temps tarda el tipus 1 en cuinarse? " + food.CalculateTimeCooking(1));
            Console.WriteLine("Quantitat de hamburgueses: " + food.Quantity);
            food.UpdateInventory(5);
            Console.WriteLine("Quantitat de hamburgueses: " + food.Quantity);


        }
    }
}