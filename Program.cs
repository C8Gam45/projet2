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
