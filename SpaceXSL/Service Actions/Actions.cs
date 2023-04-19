using SpaceXDAL.ADO.HelperClasses;
using SpaceXSL.CRUDServices;
using SpaceXDAL.ADO;

namespace SpaceXSL.Service_Actions
{
    public class Actions : RowsAffectedHelper
    {
        public string? ResultText { get; private set; }

        public void CallApiAndPostFetchedData()
        {
            RowsAffected = 0;
            foreach (KeyValuePair<int, string> item in SpaceXApiEndpointDictionary.GetDictionary())
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

        public void RunAPITimeUpdateCheck()
        {
            DateTime now = DateTime.Now.AddDays(-1);
            DateTime lastUpdated = new DateTime();
            ADO_Commands? getLastUpdate = new ADO_Commands();
            lastUpdated = getLastUpdate.RetrieveLastUpdated();
            int compare = DateTime.Compare(lastUpdated, now);

            if (compare < 0)
            {
                Actions actions = new Actions();
                actions.CallApiAndPostFetchedData();
                foreach (KeyValuePair<int, string> item in SpaceXApiEndpointDictionary.GetDictionary())
                {
                    int endpointId = item.Key;
                    getLastUpdate.UpdateLastUpdatedTime(endpointId);
                }
            }
            else
            {
                Console.WriteLine("SpaceX API Information is up to date.");
            }
        }
    }
}