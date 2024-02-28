using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Client : APersona, IInteraccio
    {
        public int CodiClient { get; set; }
        public int TipusClient { get; set; }

        public Client(string nom, string cognom, int codi, int codiClient, int tipusClient) : base(nom, cognom, codi)
        {
            this.CodiClient = codiClient;
            this.TipusClient = tipusClient;
        }
        public int GenerarCodi()
        {
            Random rnd = new Random();
            return rnd.Next(9999);
        }

        public string Notifica()
        {
            return $"Notificació client {this.Nom}";
        }

        public override string Saluda(string cognom, string nom)
        {
            return $"Hola {nom} {cognom}";
        }

        public double CalculaDescompte(int tipusClient)
        {
            return tipusClient * 0.1;
        }

        public override string ToString()
        {
            return $"Nom: {Nom}\n" +
                $"Cognom: {Cognom}\n" +
                $"Codi: {Codi}\n" +
                $"CodiClient: {CodiClient}\n" +
                $"TipusClient: {TipusClient}";
        }
    }
}
