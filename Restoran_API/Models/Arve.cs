namespace Restoran_API.Models
{
    public class Arve
    {
        public int Id { get; set; }
        public int Tellimus_Id { get; set; }
        public int Hind {  get; set; }

        public Arve (int id, int tellimus_Id, int hind)
        {
            Id = id;
            Tellimus_Id = tellimus_Id;
            Hind = hind;
        }
    }
}
