using AutoMapper;

namespace AutoMapperExample.Models.AutoMapper
{
    public class Mappings:Profile
    {
        public Mappings()
        {
            CreateMap<Kitap,KitapDTO>().ReverseMap();
            CreateMap<Ogrenci,OgrenciDTO>()
                .ForMember(x=>x.FullName,option => option.MapFrom(y=>$"{y.FirstName} {y.LastName}")).ReverseMap();
        }
    }
}
