namespace projet2;

class Compte
{
    public int Numero { get; set; }
    public string Nom { get; set; }
    public decimal Solde { get; set; }

    public Compte(int numero, string nom, decimal solde)
    {
        Numero = numero;
        Nom = nom;
        Solde = solde;
    }

    public void Crediter(decimal montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine("Erreur : Le montant à créditer doit être positif.");
            return;
        }
        Solde += montant;
    }

    public void Debiter(decimal montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine("Erreur : Le montant à débiter doit être positif.");
            return;
        }
        if (Solde - montant < 0)
        {
            Console.WriteLine("Erreur : Solde insuffisant pour débiter ce montant.");
            return;
        }
        Solde -= montant;
    }

    public void Transferer(Compte destinataire, decimal montant)
    {
        if (montant <= 0)
        {
            Console.WriteLine("Erreur : Le montant à transférer doit être positif.");
            return;
        }
        if (Solde - montant < 0)
        {
            Console.WriteLine("Erreur : Solde insuffisant pour transférer ce montant.");
            return;
        }
        Solde -= montant;
        destinataire.Solde += montant;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var compte1 = new Compte(1, "Alice", 1000m);
        var compte2 = new Compte(2, "Bob", 500m);
        var compte3 = new Compte(3, "Charlie", 750m);

        

        Console.WriteLine("Numéro / Nom / Solde");
        var comptes = new[] { compte1, compte2, compte3 };
        foreach (var c in comptes)
        {
            Console.WriteLine($"{c.Numero} / {c.Nom} / {c.Solde}");
        }
    }
}
