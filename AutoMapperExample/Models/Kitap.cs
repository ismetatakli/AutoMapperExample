namespace AutoMapperExample.Models
{
    public class Kitap
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public Ogrenci Ogrenci { get; set; }
    }
}
