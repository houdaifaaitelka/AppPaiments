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

    }
}