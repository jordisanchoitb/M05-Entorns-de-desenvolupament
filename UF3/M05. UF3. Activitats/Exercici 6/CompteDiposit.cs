using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class CompteDiposit: ACompte, IInteraccio
    {
        public int SemaforRisc { get; set; }

        public CompteDiposit(long numCompte, string nomTitular, float saldoCompte, int semaforRisc) : base(numCompte, nomTitular, saldoCompte)
        {
            this.SemaforRisc = semaforRisc;
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

        public void MostrarRisc(int risc)
        {
            switch (risc)
            {
                case 1:
                case 2:
                    Console.WriteLine("El compte té un risc baix");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("El compte té un risc mitjà");
                    break;
                case 5:
                case 6:
                    Console.WriteLine("El compte té un risc alt");
                    break;
                default:
                    Console.WriteLine("El compte té un risc desconegut");
                    break;
            }
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
