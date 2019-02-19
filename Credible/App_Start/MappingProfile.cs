using AutoMapper;
using Credible.DTO;
using Credible.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Credible.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<ClientCourses, ClientCoursesDto>();
            Mapper.CreateMap<ClientCoursesDto, ClientCourses>();
            Mapper.CreateMap<Clients, ClientsDto>();
            Mapper.CreateMap<ClientsDto, Clients>();
            Mapper.CreateMap<Registrants, RegistrantsDto>();
            Mapper.CreateMap<RegistrantsDto, Registrants>();
        }
    }
}