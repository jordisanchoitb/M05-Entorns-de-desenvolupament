using System;

namespace noparell
{
    public class noparell
    {
        public static void Main()
        {
            int numero;

            Console.WriteLine("Donem un numero i et dic si es inparell o no: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if ((numero % 2) != 0)
            {
                Console.WriteLine("Es inparell");
            }
            else
            {
                Console.WriteLine("Es parell");
            }

        }
    }
}
