using AutoMapper;
using AutoMapperExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMapper _mapper;

        public WeatherForecastController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            Ogrenci ogr = new Ogrenci
            {
                Id = 1,
                FirstName = "Ýsmet",
                LastName = "Ataklý",
                Age = 29,
                Books = new List<Kitap>
                {
                    new Kitap
                    {
                        Id = 1,
                        Name = "Kitap1",
                        PageCount = 500,
                    },
                    new Kitap
                    {
                        Id = 2,
                        Name = "Kitap2",
                        PageCount = 500,
                    }
                }
            };

            var dto = _mapper.Map<OgrenciDTO>(ogr);
            return Ok(dto);
        }
    }
}
