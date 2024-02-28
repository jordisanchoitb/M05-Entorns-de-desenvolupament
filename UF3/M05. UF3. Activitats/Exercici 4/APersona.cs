using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public abstract class APersona
    {
        public string Nom { get; set; }
        public string Cognom { get; set; }
        public int Codi { get; set; }

        public APersona(string nom, string cognom, int codi)
        {
            this.Nom = nom;
            this.Cognom = cognom;
            this.Codi = codi;
        }

        public abstract string Saluda(string cognom, string nom);
    }
}
