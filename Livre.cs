public class Livre : Media
{
    public string Auteur { get; set; }

    public Livre(string titre, int numeroReference, int nombreExemplaires, string auteur)
        : base(titre, numeroReference, nombreExemplaires)
    {
        Auteur = auteur;
    }

    public override void AfficherInfos()
    {
        Console.WriteLine($"Livre - Titre: {Titre}, Auteur: {Auteur}, Numéro de référence: {NumeroReference}, Nombre d'exemplaires: {NombreExemplaires}");
    }
}
