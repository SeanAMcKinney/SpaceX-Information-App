using SpaceXDAL.ADO.HelperClasses;
using SpaceXSL.CRUDServices;
using Microsoft.Win32.TaskScheduler;
using SpaceXDAL.ADO.Components;
using SpaceXDAL.ADO;
using SpaceXSL.Service_Actions;

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
            string apiCheck = "Check SpaceX API For Updated Information";
            TaskDefinition td = TaskService.Instance.NewTask();
            DateTime now = DateTime.Now.AddDays(-1);
            DateTime lastUpdated = new DateTime();
            ADO_Commands? lastUpdate = new ADO_Commands();
            lastUpdated = lastUpdate.RetrieveLastUpdated();

            td.RegistrationInfo.Author = "Sean McKinney";
            td.RegistrationInfo.Description = apiCheck;
            td.Actions.Add(new ExecAction(@"C:\Users\Student\source\repos\PortfolioProjects\SpaceX Information App\SpaceXConsole\bin\Debug\net6.0\SpaceXConsole.exe"));

            int compare = DateTime.Compare(lastUpdated, now);

            if (compare < 0)
            {
                foreach (KeyValuePair<int, string> item in SpaceXApiEndpointDictionary.GetDictionary())
                {
                    int endpointId = item.Key;
                    string name = item.Value;
                    lastUpdate.UpdateLastUpdatedTime(endpointId);
                }
                Actions actions = new Actions();
                actions.CallApiAndPostFetchedData();
                
            }
            else
            {
                Console.WriteLine("SpaceX API Information is up to date.");
            }
        }
    }
}