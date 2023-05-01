using AutoMapper;

namespace SpaceXSL.SLMapper
{
    public class Source<T>
    {
        public T? Value { get; set; }
    }

    public class Destination<T>
    {
        public T? Value { get; set; }
    }

   // var genericMap = new MapperConfiguration(cfg => cfg.CreateMap(typeof(Source<>), typeof(Destination<>)));

}