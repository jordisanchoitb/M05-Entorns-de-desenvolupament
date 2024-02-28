using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEx
{
    public class Partner : APersona , IInteraccio
    {
        public int CodiPartner { get; set; }
        public int IndexReliability { get; set; }

        public Partner(string nom, string cognom, int codi, int codiPartner, int indexReliability) : base(nom, cognom, codi)
        {
            this.CodiPartner = codiPartner;
            this.IndexReliability = indexReliability;
        }

        public int GenerarCodi()
        {
            Random rnd = new Random();
            return rnd.Next(9999);
        }

        public string Notifica()
        {
            return $"Notificació partner {this.Nom}";
        }

        public override string Saluda(string cognom, string nom)
        {
            return $"Hola {nom} {cognom}";
        }

        public string MostrarRisc(int indexReliability)
        {
            return $"El risc de l'empresa és de {indexReliability}";
        }

        public override string ToString()
        {
            return $"Nom: {Nom}\n" +
                $"Cognom: {Cognom}\n" +
                $"Codi: {Codi}\n" +
                $"CodiPartner: {CodiPartner}\n" +
                $"IndexReliability: {IndexReliability}";
        }
    }
}
