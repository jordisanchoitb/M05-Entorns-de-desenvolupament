using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class CompteCorrent : ACompte, IInteraccio
    {
        public float Balance { get; set; }

        public CompteCorrent(long numCompte, string nomTitular, float saldoCompte, float balance) : base(numCompte, nomTitular, saldoCompte)
        {
            this.Balance = balance;
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

        public bool PucExtreure(float quantitat)
        {
            if (this.SaldoCompte - quantitat >= this.Balance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void MostrarDades()
        {
            Console.WriteLine("Compte corrent");
            Console.WriteLine("Número de compte: " + this.NumeroCompte);
            Console.WriteLine("Nom del titular: " + this.NomTitular);
            Console.WriteLine("Saldo del compte: " + this.SaldoCompte);
        }
    }
}
