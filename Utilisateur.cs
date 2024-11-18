using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    // Creation de la classe Utilisateur
    internal class Utilisateur
    {
        //la declaration des paramettres et listes de la classe 
        public string Nom { get; set; }
        public List<Paiement> Paiements { get; set; }

        //le constructeur de la classe Utilisateur
        public Utilisateur(string nom)
        {
            Nom = nom;
            Paiements = new List<Paiement>();
        }

        //la creation de la methode pour ajouter un paiement effectuer par un utilisateur
        public void AjouterPaiement(Paiement paiement)
        {
            Paiements.Add(paiement);
        }
        public void Afficherinfos()
        {
            Console.WriteLine($"l'utilisateur est {Nom} et a payer : ");
            foreach (var paiement in Paiements)
            {
                paiement.AfficherDetails();
            }
        }
    }
}
