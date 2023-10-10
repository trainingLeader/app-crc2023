using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Apicrc.Profiles
{
    public class MappingProfiles : Profile
    {
        //CreateMap<Pais,PaisDto>().ReverseMap();
        /*CreateMap<Estado,EstadoDto>()
        .ForMember(dest => dest.IdEstado, opt => opt.MapFrom(src => src.IdCod))
        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.nombreEstado))
        .ReverseMap();*/
    }
}