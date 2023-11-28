using System;

namespace Calculator
{
    public class Calculator
    {
        public static void Main()
        {
            const string resolt = "El resultat es: ";
            const string infoNumbers = "Posem el dos numeros que vols ";
            const string notDiv0 = "No es pot dividir entre 0";

            string anotherCalc;
            int numero1, numero2, numero_calc;
            bool calculator;
            calculator = false;
            do {
                Console.WriteLine("Que vols calcular");
                Console.WriteLine("1- Sumar, 2- Restar, 3-Multiplicar, 4-Dividir, 0-Sortir");
                numero_calc = Convert.ToInt32(Console.ReadLine());
                
                switch (numero_calc)
                {
                    case 0:
                        calculator = false;
                        break;
                    case 1:
                        Console.WriteLine(infoNumbers + "suma");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(resolt +  (numero1+numero2));
                        break;
                    case 2:
                        Console.WriteLine(infoNumbers + "resta");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(resolt + (numero1-numero2));
                        break;
                    case 3:
                        Console.WriteLine(infoNumbers + "multiplicar");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(resolt + (numero1*numero2));
                        break;
                    case 4:
                        Console.WriteLine(infoNumbers + "dividir");
                        numero1 = Convert.ToInt32(Console.ReadLine());
                        numero2 = Convert.ToInt32(Console.ReadLine());
                        if (numero2 != 0)
                        {
                            Console.WriteLine(resolt + (numero1 / numero2));
                        }
                        else {
                            Console.WriteLine(notDiv0);
                        }
                        break;
                }
                if (numero_calc != 0)
                {
                    Console.WriteLine("Vols fer un altre calcul? (si/no):");
                    anotherCalc = Console.ReadLine();
                    if (anotherCalc == "si")
                    {
                        calculator = true;
                        Console.Clear();
                    }
                    else
                    {
                        calculator = false;
                    }
                }
                

            } while (calculator);
        }
    }
}
