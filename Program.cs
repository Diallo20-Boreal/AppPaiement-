using AppPaiements;
// Programme principal
internal class Program
{
    private static void Main(string[] args)
    {
        // les instances de la classe Carte Credit
        CarteCredit carteCredit1 = new CarteCredit(42013, 10000, "Epargne");
        CarteCredit carteCredit2 = new CarteCredit(95213, 75000, "Investisement");
        CarteCredit carteCredit3 = new CarteCredit(86313, 7500, "Depenses");
        
        //Affichage des details de ces objets
        List<CarteCredit> CarteCredits = new List<CarteCredit> { carteCredit1, carteCredit2, carteCredit3 };
        Console.WriteLine("les cartes de credits sont :");
        foreach (var CarteCredit in CarteCredits)
        {
            CarteCredit.AfficherDetails();
        }
        // Pour obtenir une espece entre les affichages de object 
        Console.WriteLine("        ---------------------------------------------------------");

        //les instances de la classe Paypal
        Paypal paypal1 = new Paypal("alhassane.diallo@gmail.com", 2500000, "Combine");
        Paypal paypal2 = new Paypal("mariam@gmail.com", 15000, "Soon");

        //Affichage des details de ces objets de la classe Paypal
        List<Paypal> paypals = new List<Paypal> { paypal1, paypal2 };
        Console.WriteLine("les comptes paypals sont :");
        foreach (var Paypal in paypals)
        {
            Paypal.AfficheDetails();
        }
        // Pour obtenir une espece entre les affichages de object 
        Console.WriteLine("        ---------------------------------------------------------");

        // les instances Utilisateur 
        
        Utilisateur utilisateur1 = new Utilisateur("Diallo");
        List<Utilisateur> utilisateurs = new List<Utilisateur> { utilisateur1 };
        foreach(var utilisateur in utilisateurs) 
        { 
            utilisateur.AjouterPaiement(paypal1);
            utilisateur.AjouterPaiement(paypal2);
            utilisateur.AjouterPaiement(carteCredit1);
            utilisateur.AjouterPaiement(carteCredit2);
            utilisateur.AjouterPaiement(carteCredit3);

            utilisateur.Afficherinfos();
            // Pour obtenir une espece entre les affichages de object 
            Console.WriteLine("       FIN DU PROGRAMME");
        }
    }
}