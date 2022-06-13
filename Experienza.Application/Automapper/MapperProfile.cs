using AutoMapper;
using Domain.Models;
using EntitiesDTOs;

namespace Experienza.Application.Automapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<BookDTO, Book>().ReverseMap();
        }
    }
}
