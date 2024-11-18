using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paiement
    {
        // la declaration des paramettres de la classe 
        public double Montant { get; set; }
        public string Description { get; set; }

        //le constructeur de la classe
        public Paiement(double montant, string description)
        {
            Montant = montant;
            Description = description;
        }

        //la creation de la methode afficher
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"le montant est {Montant} et ça description est {Description}");
        }
    }
}
