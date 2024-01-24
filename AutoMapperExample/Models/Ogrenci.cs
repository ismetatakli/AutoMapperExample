namespace AutoMapperExample.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Kitap> Books { get; set; }
    }
}
