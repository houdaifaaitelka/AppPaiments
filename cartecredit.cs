using System;

public class cartecredit
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
