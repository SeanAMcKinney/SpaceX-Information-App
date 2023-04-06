using SpaceXDAL.ADO.Components;
using SpaceXDAL.ADO.HelperClasses;
using System;
using System.Data.SqlClient;

namespace SpaceXDAL.ADO
{
    public class ADO_Commands : RowsAffectedHelper
    {
        public string ResultText { get; private set; }
        public void InsertEndpointIdAndJsonString(int endpointId, string json)
        {
            string sql = "INSERT INTO [dbo].[SpaceX_Endpoint_JSON](Endpoint_ID, Endpoint_JSON)";
            sql += " VALUES(@Endpoint_ID, @Endpoint_JSON)";

            try
            {
                using (SqlConnection cnn = new SqlConnection(AppSettings.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Endpoint_ID", endpointId));
                        cmd.Parameters.Add(new SqlParameter("@Endpoint_JSON", json));

                        cnn.Open();
                        RowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ResultText = ex.ToString();
            }
        }
    }
}

