namespace AutoMapperExample.Models
{
    public class OgrenciDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<KitapDTO> Books { get; set; }
    }
}
