class Program
{
    static void Main(string[] args)
    {
        Livre livre = new Livre("Les Misérables", 1, 5, "Victor Hugo");
        DVD dvd = new DVD("Inception", 2, 3, 148);
        CD cd = new CD("Abbey Road", 3, 10, "The Beatles");

        livre.AfficherInfos();
        dvd.AfficherInfos();
        cd.AfficherInfos();
    }
}