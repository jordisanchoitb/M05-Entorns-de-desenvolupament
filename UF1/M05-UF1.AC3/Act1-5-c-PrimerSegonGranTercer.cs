using System;

namespace primersegon_mesgran_tercer
{
    public class primersegon_mesgran_tercer
    {
        public static void Main()
        {
            int numero1, numero2, numero3;

            Console.WriteLine("Donem un primer numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Donem un segon numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Donem un tercer numero: ");
            numero3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El primer nombre + es segon nombre es mes gran que el tercer?: " + ((numero1 + numero2) > numero3));
            Console.ReadLine();
        }
    }
}