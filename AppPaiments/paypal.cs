using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiments
{
    internal class paypal : Paiement
    {
        public string email { get; set; }
        public paypal(double montant, string description, string email)
            : base(montant, description)
        {
            email = email;
        }
        public new void AfficherDetails()
        {
            Console.WriteLine($"PayPal: {email}, Montant: {Montant}, Description: {Description}");
        }
    }
}
