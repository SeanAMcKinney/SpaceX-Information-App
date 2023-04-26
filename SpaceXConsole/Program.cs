using AutoMapper;
using Newtonsoft.Json;
using SpaceXDAL.EntityModles;
using SpaceXSL.DTOs;
using SpaceXSL.Service_Actions;
using SpaceXSL.SLMapper;

namespace SpaceXConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Actions action = new Actions();
            action.RunAPITimeUpdateCheck();

            string crewJson = Actions.GetJson(1);
            List<CrewEM> crewEM = JsonConvert.DeserializeObject<List<CrewEM>>(crewJson);
            foreach (var crew in crewEM)
            {
                Console.WriteLine($"Name: {crew.name}\n" +
                    $"Agency: {crew.agency}\n" +
                    $"Wikipedia: {crew.wikipedia}\n" +
                    $"Status: {crew.status}\n" +
                    $"ID: {crew.id}\n\n");
            }

            CrewEM crewObj = new(); 
            var mapper = ObjectMapperConfig.InitializeAutoMapper();
            CrewDTO crewDTO = mapper.Map<CrewEM, CrewDTO>(crewObj);
            

            List<CrewDTO> crewDto = JsonConvert.DeserializeObject<List<CrewDTO>>(crewJson);
            foreach (var crew in crewDto)
            {
                Console.WriteLine($"****This is the CrewDTO****\n" +
                    $"Name: {crew.Name}\n" +
                    $"Agency: {crew.Agency}\n" +
                    $"Wikipedia: {crew.Wikipedia}\n" +
                    $"Status: {crew.Status}\n" +
                    $"ID: {crew.Id}\n\n");
            }
        }
    }
}