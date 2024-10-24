using System;

public class paypal
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
