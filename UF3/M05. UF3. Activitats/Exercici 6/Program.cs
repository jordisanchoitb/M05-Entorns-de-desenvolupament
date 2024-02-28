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
            CompteCorrent comptecorrent = new CompteCorrent(123456789, "Jordi Sancho", 1000, 100);
            CompteDiposit comptediposit = new CompteDiposit(987654321, "Jordi Sancho", 1000, 3);
            CompteEstalvi compteestalvi = new CompteEstalvi(123456789, "Jordi Sancho", 1000, 3);

            comptecorrent.MostrarDades();
            Console.WriteLine(comptecorrent.PucExtreure(20));
            Console.WriteLine(comptecorrent.PucExtreure(2000));
            Console.WriteLine();
            comptediposit.MostrarDades();
            comptediposit.MostrarRisc(comptediposit.SemaforRisc);
            Console.WriteLine();
            compteestalvi.MostrarDades();
            Console.WriteLine(compteestalvi.CalculaInteresos(5));


        }
    }
}