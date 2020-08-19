using AutoMapper;
using Final_Vidly.Dtos;
using Final_Vidly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}