using SpaceXDAL.ADO;
using System.Net.Http.Headers;

namespace SpaceXSL.CRUDServices
{
    public class CRUDService
    {
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
                    HttpResponseHeaders headers = response.Headers;
                    string eTag = headers.ETag.Tag;
                    string json = await response.Content.ReadAsStringAsync();
                    string result = GetETagFromDb(endpointId);
                    if (result == null)
                    {
                        PostToDB(endpointId, json, eTag);
                    }
                    else if (eTag != result)
                    {
                        UpdateDB(json, eTag, endpointId);
                    }
                    else
                    {
                        await Console.Out.WriteLineAsync($"Db shows no change. The API ETag: {eTag} \n" +
                            $" and the DB ETag with the Endpoint ID of {endpointId} ETag: {result} \n" +
                            $" are the same.");
                    }
                }
                else
                {
                    Console.WriteLine(response.StatusCode.ToString() + " Could not get SpaceX Json at this time");
                }
            }
        }

        // POST

        public static void PostToDB(int endpointId, string json, string eTag)
        {
            ADO_Commands post = new ADO_Commands();
            post.InsertEndpointIdAndJsonStringAndETag(endpointId, json, eTag);
        }

        // GET
        public static string GetETagFromDb(int endpointId)
        {
            ADO_Commands getEtag = new ADO_Commands();
            string result = getEtag.RetrieveETag(endpointId);
            return result;
        }

        // UPDATE
        public static void UpdateDB(string json, string eTag, int endpointId)
        {
            ADO_Commands update = new ADO_Commands();
            update.UpdateJsonAndETag(json, eTag, endpointId);
        }

    }
}
