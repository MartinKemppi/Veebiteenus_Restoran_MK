namespace Restoran_API.Models
{
    public class Tellimus
    {
        public int Id { get; set; }
        public string Kasutaja { get; set; }
        public List <string> TooteNimed {  get; set; }
        public List <int> Kogused { get; set; }
        public float Hind {  get; set; }
        public int Laud { get; set; }
        public string Komentaar {  get; set; }
        public string Seisukord { get; set; }

        public Tellimus(int id, string kasutaja, 
                        List<string> tooteNimed, 
                        List<int> kogused, float hind, int laud, string seisukord, string komentaar)
        {
            Id = id;
            Kasutaja = kasutaja;
            TooteNimed = tooteNimed;
            Kogused = kogused;
            Hind = hind;
            Laud = laud;
            Seisukord = seisukord;
            Komentaar = komentaar;
        }
    }
}
