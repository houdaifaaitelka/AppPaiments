using AppPaiments;

internal class Program
{
   static void Main(string[] args)
    {
        CarteCredit carte1 = new CarteCredit(100.50, "Achat de imprimant", 124010000);
        CarteCredit carte2 = new CarteCredit(250.75, "Achat d'un clavier", 111111121);
        CarteCredit carte3 = new CarteCredit(50.00, "Achat de roman", 123456789);
        carte1.AfficherDetails();
        carte2.AfficherDetails();
        carte3.AfficherDetails();





      
        paypal paypal1 = new paypal(89.00, "Achat d'abonnement", "aitelkadihoudaifa@gmail.com");
        paypal paypal2 = new paypal(100.99, "Achat d'abonnement", "hassan30@gmail.com");

      
        paypal1.AfficherDetails();
        paypal2.AfficherDetails();

    }
}