using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CUstomerDto>();
            CreateMap<MembershipType, MembershipTypeDto>();
            CreateMap<Movie, MovieDto>();
            CreateMap<Genre, GenreDto>();
            CreateMap<Rental, RentalDto>();

            CreateMap<CUstomerDto, Customer>().ForMember(c => c.ID, opt => opt.Ignore());
            CreateMap<MovieDto, Movie>().ForMember(m => m.ID, opt => opt.Ignore());
        }
    }
}