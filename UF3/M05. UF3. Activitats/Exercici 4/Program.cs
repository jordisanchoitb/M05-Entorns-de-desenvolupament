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
            Proveidor proveidor = new Proveidor("Jordi", "Sancho", 1, 1, "30 dies");
            Client client = new Client("Jordi", "Sancho", 1, 1, 1);
            Partner partner = new Partner("Jordi", "Sancho", 1, 2, 100);

            Console.WriteLine(proveidor.Notifica());
            Console.WriteLine(proveidor.Saluda("Sancho", "Jordi"));
            Console.WriteLine(proveidor.RetornaMarge(30));
            Console.WriteLine(proveidor.ToString());

            Console.WriteLine(client.Notifica());
            Console.WriteLine(client.Saluda("Sancho", "Jordi"));
            Console.WriteLine(client.CalculaDescompte(1));
            Console.WriteLine(client.ToString());

            Console.WriteLine(partner.Notifica());
            Console.WriteLine(partner.Saluda("Sancho", "Jordi"));
            Console.WriteLine(partner.MostrarRisc(100));
            Console.WriteLine(partner.ToString());
                        

        }
    }
}