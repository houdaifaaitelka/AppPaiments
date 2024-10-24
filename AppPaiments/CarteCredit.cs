using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiments
{
    internal class CarteCredit : Paiement
    {
        public int NumeroCarte { get; set; }
        public CarteCredit(double montant, string description, int numeroCarte)
            : base(montant, description)
        {
            NumeroCarte = numeroCarte;
        }
        public new void AfficherDetails()
        {
            Console.WriteLine($"Carte de Crédit: {NumeroCarte}, Montant: {Montant}, Description: {Description}");
        }
    }
}
