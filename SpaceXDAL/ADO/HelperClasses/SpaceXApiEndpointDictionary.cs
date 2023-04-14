using System.Collections.Generic;

namespace SpaceXDAL.ADO.HelperClasses
{
    public class SpaceXApiEndpointDictionary
    {
        public static Dictionary<int, string> GetDictionary()
        {
            var endpointIdAndEndpointName = new Dictionary<int, string>()
            {
                { 1, "crew" },
                { 2, "launches" },
            };
            return endpointIdAndEndpointName;
        }
    }
}
