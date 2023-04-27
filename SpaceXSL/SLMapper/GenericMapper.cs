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
using SpaceXSL.SLMapper;

namespace SpaceXSL.SLMapper
{
    public class Source<T>
    {
        public T Value { get; set; }
    }

    public class Destination<T>
    {
        public T Value { get; set; }
    }


    public class GenericMapper
    {
        
    }
}



//public static Mapper? InitializeAutoMapper()
//{
//    var config = new MapperConfiguration(cfg =>
//    {
//        cfg.CreateMap<Source<T>, CrewDTO>();
//    });

//    var mapper = new Mapper(config);

//    return mapper;
//}