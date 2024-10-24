﻿using System;

public class Paiement
{
    public double Montant { get; set; }
    public string Description { get; set; }

    public Paiement(double montant, string description)
    {
        Montant = montant;
        Description = description;
    }
    public void AfficherDetails()
    {
        Console.WriteLine($"Paiement: {Montant} ---> {Description}");
    }
}
}
