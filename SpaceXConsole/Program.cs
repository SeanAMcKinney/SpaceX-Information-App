using SpaceXSL.Service_Actions;

namespace SpaceXConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Actions actions = new Actions();
            actions.CallApiAndPostFetchedData();
        }
    }
}