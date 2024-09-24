public class Media
{
    public string Titre { get; set; }
    public int NumeroReference { get; set; }
    public int NombreExemplaires { get; set; }

    public Media(string titre, int numeroReference, int nombreExemplaires)
    {
        Titre = titre;
        NumeroReference = numeroReference;
        NombreExemplaires = nombreExemplaires;
    }

    // Méthode polymorphique à redéfinir dans les sous-classes
    public virtual void AfficherInfos()
    {
        Console.WriteLine($"Titre: {Titre}, Numéro de référence: {NumeroReference}, Nombre d'exemplaires: {NombreExemplaires}");
    }
}
