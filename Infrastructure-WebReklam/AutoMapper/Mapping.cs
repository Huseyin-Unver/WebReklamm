using ApplicationCore_WebReklam.DTO_s.CityDTO;
using ApplicationCore_WebReklam.Entities.Concrete;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure_WebReklam.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<City, CreateCityDTO>().ReverseMap();
            CreateMap<City, UpdateCityDTO>().ReverseMap();

        }
    }
}
