namespace Restoran_API.Models
{
    public class Restoran
    {
        public int Id { get; set; }
        public string Nimi { get; set; }
        public int Laud { get; set; }
        public int LauadeMahutavus { get; set; }
        public string Tagid { get; set; }

        public Restoran(int id, string nimi, int laud, int lauadeMahutavus, string tagid)
        {
            Id = id;
            Nimi = nimi;
            Laud = laud;
            LauadeMahutavus = lauadeMahutavus;
            Tagid = tagid;
        }
    }
}
