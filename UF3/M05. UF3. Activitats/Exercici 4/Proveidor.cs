using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Proveidor : APersona, IInteraccio
    {
        public int CodiProveidor { get; set; }
        public string? TerminiPagament { get; set; }

        public Proveidor(string nom, string cognom, int codi, int codiProveidor, string terminiPagament) : base(nom, cognom, codi)
        {
            this.CodiProveidor = codiProveidor;
            this.TerminiPagament = terminiPagament;
        }
        public int GenerarCodi()
        {
            Random rnd = new Random();
            return rnd.Next(9999);
        }

        public string Notifica()
        {
            return $"Notificació proveidor {this.Nom}";
        }

        public override string Saluda(string cognom, string nom)
        {
            return $"Hola {nom} {cognom}";
        }

        public string RetornaMarge(int terminiPagament)
        {
            return $"El marge de pagament és de {terminiPagament}";
        }

        public override string ToString()
        {
            return $"Nom: {Nom}\n" +
                $"Cognom: {Cognom}\n" +
                $"Codi: {Codi}\n" +
                $"CodiProveidor: {CodiProveidor}\n" +
                $"TerminiPagament: {TerminiPagament}";
        }
    }
}
