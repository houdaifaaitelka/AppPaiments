using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiments
{
    internal class Utilisateur 
    {
        public string Nom { get; set; }
        public List<Paiement> Paiements { get; set; }

        public Utilisateur(string nom) 
        {
            Nom = nom;
            Paiements = new List<Paiement>();
        }

        public void AjouterPaiement(Paiement paiement)
        {
            Paiements.Add(paiement);
        }

        public void AfficherListePaiements() 
        {
            Console.WriteLine($"Liste des paiements de {Nom}:");
            foreach (var paiement in Paiements)
            {
                paiement.AfficherDetails();
            }
        }
    }
}