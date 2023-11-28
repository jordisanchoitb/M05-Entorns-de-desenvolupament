using System;

namespace CalculaAreaTriangle
{
    public class CalculaAreaTriangle
    {
        public static void Main()
        {
            int base_triangle, alzada_triangle;

            Console.WriteLine("Donem la base del Triangle: ");
            base_triangle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Donem la alzada del Triangle: ");
            alzada_triangle = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("L'area del triangle es: " + (base_triangle * alzada_triangle) / 2);
            Console.ReadLine();
        }
    }
}
