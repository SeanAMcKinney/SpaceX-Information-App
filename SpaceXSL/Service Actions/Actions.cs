using SpaceXDAL.ADO.HelperClasses;
using SpaceXSL.CRUDServices;

namespace SpaceXSL.Service_Actions
{
    public class Actions : RowsAffectedHelper
    {
        public string? ResultText { get; private set; }
        public void CallApiAndPostFetchedData()
        {
            RowsAffected = 0;
            foreach (KeyValuePair<int, string> item in SpaceXApiEndpointDictionaryHelper.GetDictionary())
            {
                int endpointId = item.Key;
                string name = item.Value;
                CRUDService.CallSpaceXAPI(endpointId, name)
                .Wait();

                RowsAffected += 1;
                ResultText = $"Endpoint Name: {name}\n" +
                    $"Endpoint ID: {endpointId}\n";

                Console.WriteLine(ResultText + "\n");
            }
            Console.WriteLine($"Rows Affected: {RowsAffected}");
        }
    }
}
