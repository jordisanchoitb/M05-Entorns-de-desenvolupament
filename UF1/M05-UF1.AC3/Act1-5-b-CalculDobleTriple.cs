using System;

namespace calculdoble_triple
{
    public class calculdoble_triple
    {
        public static void Main()
        {
            int numero;

            Console.WriteLine("Donem un numero i et tornare el seu doble i triple: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El doble es: " + numero * 2);
            Console.WriteLine("El triple es: " + numero * 3);
            Console.ReadLine();
        }
    }
}

