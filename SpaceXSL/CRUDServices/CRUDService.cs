using SpaceXDAL.ADO;
using System.Net.Http.Headers;

namespace SpaceXSL.CRUDServices
{
    public class CRUDService
    {
        public static string? json { get; set; }

        public static async Task CallSpaceXAPI(int endpointId, string name)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.spacexdata.com/v4/");
                client.Timeout = new TimeSpan(0, 0, 30);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //GET Method

                HttpResponseMessage response = await client.GetAsync(name);
                if (response.IsSuccessStatusCode)
                {
                    json = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(json);
                        UpdateDB(endpointId, json);
                }
                else
                {
                    Console.WriteLine(response.StatusCode.ToString() + " Could not get SpaceX Json at this time");
                }
            }
        }

        public static void UpdateDB(int endpointId, string json)
        {
            ADO_Commands post = new ADO_Commands();
            post.InsertEndpointIdAndJsonString(endpointId, json);
        }
    }
}
