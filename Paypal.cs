using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    // Creation de la classe Paypal qui herite de la classe Paiement 
    internal class Paypal : Paiement
    {
        // la declaration des paramettres de la classe 
        public string Courriel { get; set; }

        //le constructeur de la classe 
        public Paypal(string email, double montant, string description) : base(montant, description)
        {
            Courriel = email;
        }
        //la creation de la methode afficher
        public virtual void AfficheDetails()
        {
            Console.WriteLine($"le montant est {Montant}, la description est {Description} et son email est {Courriel}.");
        }
    }
}
