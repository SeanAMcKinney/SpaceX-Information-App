using SpaceXDAL.ADO.Components;
using System;
using System.Data.SqlClient;
using System.Text;

namespace SpaceXDAL.ADO
{
    public class SqlDataAccess
    {
        public SqlDataAccess()
        {
            ConnectionString = AppSettings.ConnectionString;
        }

        public string ResultText { get; set; }
        public string ConnectionString { get; set; }

        public void ConnnectWithErrors()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(ConnectionString))
                {
                    cnn.Open();

                    ResultText = GetConnectionInformation(cnn);
                    Console.WriteLine(ResultText);
                }
            }
            catch (Exception ex)
            {
                ResultText = ex.ToString() + " Error";
                Console.WriteLine(ResultText);
            }
        }

        protected virtual string GetConnectionInformation(SqlConnection cnn)
        {
            StringBuilder sb = new StringBuilder(1024);

            sb.AppendLine("Connection String: " + cnn.ConnectionString);
            sb.AppendLine("State: " + cnn.State.ToString());
            sb.AppendLine("Connection Timeout: " + cnn.ConnectionTimeout.ToString());
            sb.AppendLine("Database: " + cnn.Database);
            sb.AppendLine("Data Source: " + cnn.DataSource);
            sb.AppendLine("Server Version: " + cnn.ServerVersion);
            sb.AppendLine("Workstation ID: " + cnn.WorkstationId);

            return sb.ToString();
        }
    }
}