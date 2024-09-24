public class DVD : Media
{
    public int Duree { get; set; } // Durée en minutes

    public DVD(string titre, int numeroReference, int nombreExemplaires, int duree)
        : base(titre, numeroReference, nombreExemplaires)
    {
        Duree = duree;
    }

    public override void AfficherInfos()
    {
        Console.WriteLine($"DVD - Titre: {Titre}, Durée: {Duree} min, Numéro de référence: {NumeroReference}, Nombre d'exemplaires: {NombreExemplaires}");
    }
}
