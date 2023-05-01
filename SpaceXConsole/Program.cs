using AutoMapper;
using AutoMapper.Configuration;
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

            // Mapper tests

            string crewJson = Actions.GetJson(1);
            List<CrewEM>? crewEM = JsonConvert.DeserializeObject<List<CrewEM>>(crewJson);
            foreach (var crew in crewEM)
            {
                Console.WriteLine($"Name: {crew.name}\n" +
                    $"Agency: {crew.agency}\n" +
                    $"Wikipedia: {crew.wikipedia}\n" +
                    $"Status: {crew.status}\n" +
                    $"ID: {crew.id}\n\n");
            }

            
            List<CrewDTO> crewDto = new();
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