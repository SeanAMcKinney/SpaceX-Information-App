using SpaceXDAL.ADO.Components;
using SpaceXDAL.ADO.HelperClasses;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SpaceXDAL.ADO
{
    public class ADO_Commands : RowsAffectedHelper
    {
        public string ResultText { get; private set; }
        public void InsertEndpointIdAndJsonStringAndETag(int endpointId, string json, string eTag)
        {
            string sql = "INSERT INTO [dbo].[SpaceX_Endpoint_JSON](Endpoint_ID, Endpoint_JSON, ETag)";
            sql += " VALUES(@Endpoint_ID, @Endpoint_JSON, @Etag)";

            try
            {
                using (SqlConnection cnn = new SqlConnection(AppSettings.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Endpoint_ID", endpointId));
                        cmd.Parameters.Add(new SqlParameter("@Endpoint_JSON", json));
                        cmd.Parameters.Add(new SqlParameter("@ETag", eTag));

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ResultText = ex.ToString();
            }
        }


        public string RetrieveETag(int endpointId)
        {
            string sql = "SELECT ETag FROM [dbo].[SpaceX_Endpoint_JSON] WHERE Endpoint_ID = @Endpoint_ID";
            try
            {
                using (SqlConnection cnn = new SqlConnection(AppSettings.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Endpoint_ID", endpointId));

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql;

                        cnn.Open();
                        cmd.ExecuteNonQuery();

                        string result = (string)cmd.ExecuteScalar();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                ResultText = ex.ToString();
                return ResultText;
            }
        }

        public string RetrieveJson(int endpointId)
        {
            string sql = "SELECT Endpoint_JSON FROM [dbo].[SpaceX_Endpoint_JSON] WHERE Endpoint_ID = @Endpoint_ID";
            try
            {
                using (SqlConnection cnn = new SqlConnection(AppSettings.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Endpoint_ID", endpointId));

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql;

                        cnn.Open();
                        cmd.ExecuteNonQuery();

                        string result = (string)cmd.ExecuteScalar();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                ResultText = ex.ToString();
                return ResultText;
            }
        }

        public DateTime RetrieveLastUpdated()
        {
            string sql = "SELECT Last_Updated FROM [dbo].[SpaceX_Endpoint_JSON] WHERE Endpoint_ID = @Endpoint_ID";
            try
            {
                using (SqlConnection cnn = new SqlConnection(AppSettings.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Endpoint_ID", 1));

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql;

                        cnn.Open();
                        cmd.ExecuteNonQuery();

                        DateTime result = (DateTime)cmd.ExecuteScalar();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                ResultText = ex.ToString();
                return DateTime.Today;
            }
        }

        public void UpdateJsonAndETag(string json, string eTag, int endpointId)
        {
            string sql = "UPDATE [dbo].[SpaceX_Endpoint_JSON] SET Endpoint_JSON = @Endpoint_JSON, ETag = @Etag WHERE Endpoint_ID = @Endpoint_ID";
            DateTime lastUpdated = DateTime.Now;

            try
            {
                using (SqlConnection cnn = new SqlConnection(AppSettings.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Endpoint_JSON", json));
                        cmd.Parameters.Add(new SqlParameter("@ETag", eTag));
                        cmd.Parameters.Add(new SqlParameter("@Endpoint_ID", endpointId));

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql;

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ResultText = ex.ToString();
                Console.WriteLine(ResultText);
            }
        }

        public void UpdateLastUpdatedTime(int endpointId)
        {
            string sql = "UPDATE [dbo].[SpaceX_Endpoint_JSON] SET Last_Updated = @Last_Updated WHERE Endpoint_ID = @Endpoint_ID";
            DateTime lastUpdated = DateTime.Now;

            try
            {
                using (SqlConnection cnn = new SqlConnection(AppSettings.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, cnn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Last_Updated", lastUpdated));
                        cmd.Parameters.Add(new SqlParameter("@Endpoint_ID", endpointId));

                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql;

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ResultText = ex.ToString();
                Console.WriteLine(ResultText);
            }
        }
    }
}