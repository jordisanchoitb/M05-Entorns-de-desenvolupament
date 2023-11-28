using System;

namespace dinslinterval
{
    public class dinslinterval
    {
        public static void Main()
        {
            int numero, intents = 3;
            bool estat = true;

            while (intents > 0 && estat)
            {
                Console.WriteLine("Intenta posar un dels numeros dins d'interval ocult: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 2 && numero < 30)
                {
                    Console.WriteLine("Molt bé has guanyat el numero escollit està dins l’interval (2, 30)");
                    estat = false;
                }
                else
                {
                    intents--;
                    Console.WriteLine("No es el numero");
                }
            }
            if (intents == 0)
            {
                Console.WriteLine("No son els numeros correctes has perdut");
            }
        }
    }
}
