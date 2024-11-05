namespace Restoran_API.Models
{
    public class Kasutaja
    {
        public int Id { get; set; }
        public string KasutajaNimi { get; set; }
        public string Salasona { get; set; }
        public string Roll {  get; set; }

        public Kasutaja(int id, string kasutajaNimi, string salasona, string roll)
        {
            Id = id;
            KasutajaNimi = kasutajaNimi;
            Salasona = salasona;
            Roll = roll;
        }
    }
}
