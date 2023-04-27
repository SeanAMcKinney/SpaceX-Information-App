using AutoMapper;
using SpaceXDAL.EntityModles;
using SpaceXSL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceXSL.Profiles
{
    public class CrewProfile : Profile
    {
        public CrewProfile() 
        {
            CreateMap<CrewEM, CrewDTO>();
        }
    }
}
