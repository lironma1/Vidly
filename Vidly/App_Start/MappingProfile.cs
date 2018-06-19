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
            //Domain to Dot --customer
            Mapper.CreateMap<Customer, CustomerDto>();
            //Dot to Domain --customer
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());

            //Domain to Dot --movie
            Mapper.CreateMap<Movie, MovieDto>();
            //Dot to Domain --movie
            Mapper.CreateMap<MovieDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore());

            //Domain to Dot --MembershipType
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();

            //Domain to Dot --Genre
            Mapper.CreateMap<Genre, GenreDto>();

        }
    }
}