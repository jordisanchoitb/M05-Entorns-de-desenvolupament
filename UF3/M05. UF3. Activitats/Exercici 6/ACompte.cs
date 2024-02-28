using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public abstract class ACompte
    {
        public long NumeroCompte { get; set; }
        public string NomTitular { get; set; }
        public float SaldoCompte { get; set; }

        public ACompte(long numCompte, string nomTitular, float saldoCompte)
        {
            NumeroCompte = numCompte;
            NomTitular = nomTitular;
            SaldoCompte = saldoCompte;
        }

        public abstract void MostrarDades();
    }
}
