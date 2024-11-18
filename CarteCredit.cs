using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    // Creation de la classe CarteCredit qui herite de la classe Paiement 
    internal class CarteCredit : Paiement
    {
        // la declaration des paramettres de la classe 
        public int NumeroCarte { get; set; }

        //le constructeur de la classe Carte Credit
        public CarteCredit(int numeroCarte, double montant, string description) : base(montant, description)
        {
            NumeroCarte = numeroCarte;
        }
        //la creation de la methode afficher
        public override void AfficherDetails()
        {
            Console.WriteLine($"le numéro de la carte est {NumeroCarte},le montant est {Montant} et la description est {Description}.");
        }
    }
}
