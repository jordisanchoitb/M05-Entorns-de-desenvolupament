using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class CompteEstalvi: ACompte, IInteraccio
    {
        public float TipusInteres { get; set; }

        public CompteEstalvi(long numCompte, string nomTitular, float saldoCompte, float tipusInteres) : base(numCompte, nomTitular, saldoCompte)
        {
            this.TipusInteres = tipusInteres;
        }

        public bool Deposita(float quantitat)
        {
            this.SaldoCompte += quantitat;
            return true;
        }

        public bool Extreura(float quantitat)
        {
            if (this.SaldoCompte >= quantitat)
            {
                this.SaldoCompte -= quantitat;
                return true;
            }
            else
            {
                return false;
            }
        }

        public float CalculaInteresos(int interesos)
        {
            return this.SaldoCompte * this.TipusInteres * interesos / 365;
        }

        public override void MostrarDades()
        {
            Console.WriteLine("Compte de dipòsit");
            Console.WriteLine("Número de compte: " + this.NumeroCompte);
            Console.WriteLine("Nom del titular: " + this.NomTitular);
            Console.WriteLine("Saldo del compte: " + this.SaldoCompte);
        }
    }
}
