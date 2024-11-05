namespace Restoran_API.Models
{
    public class Toode
    {
        public int Id { get; set; }
        public string Nimi { get; set; }
        public double Hind { get; set; }

        public Toode(int id, string nimi, double hind)
        {
            Id = id;
            Nimi = nimi;
            Hind = hind;
        }
    }
}
