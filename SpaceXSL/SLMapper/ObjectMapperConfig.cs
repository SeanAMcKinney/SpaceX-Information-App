using AutoMapper;
using SpaceXDAL.EntityModles;
using SpaceXSL.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceXSL.Service_Actions;

namespace SpaceXSL.SLMapper
{
    public class ObjectMapperConfig
    {
        public static Mapper? InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CrewEM, CrewDTO>();
            });

            var mapper = new Mapper(config);

            return mapper;
        }
    }
}
