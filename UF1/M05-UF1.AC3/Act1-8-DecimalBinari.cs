using System;

namespace decimalabinari
{
    public class decimalabinari
    {
        public static void Main()
        {
            int numero, numero_binari = 0, posicio = 1;

            Console.WriteLine("Donem un numero natural i el torno amb binari: ");
            numero = Convert.ToInt32(Console.ReadLine());
            while (numero > 0)
            {
                numero_binari = numero_binari + (numero % 2) * posicio;
                numero /= 2;
                posicio *= 10;
            }
            Console.WriteLine("El numero en binari es: " + numero_binari);
        }
    }
}
