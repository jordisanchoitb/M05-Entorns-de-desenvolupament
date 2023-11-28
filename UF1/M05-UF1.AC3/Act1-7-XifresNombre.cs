using System;

namespace xifresnombre
{
    public class xifresnombre
    {
        public static void Main()
        {
            int numero, xifres = 1;

            Console.WriteLine("Donem un numero natural i et dic cuantes xifres te: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                while (numero > 9)
                {
                    numero /= 10;
                    xifres++;
                }
                Console.WriteLine("Xifres: " + xifres);
            }
            else
            {
                Console.WriteLine("No has introduit un numero natural");
            }

        }
    }
}

