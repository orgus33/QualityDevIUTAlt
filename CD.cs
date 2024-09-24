public class CD : Media
{
    public string Artiste { get; set; }

    public CD(string titre, int numeroReference, int nombreExemplaires, string artiste)
        : base(titre, numeroReference, nombreExemplaires)
    {
        Artiste = artiste;
    }

    public override void AfficherInfos()
    {
        Console.WriteLine($"CD - Titre: {Titre}, Artiste: {Artiste}, Numéro de référence: {NumeroReference}, Nombre d'exemplaires: {NombreExemplaires}");
    }
}
