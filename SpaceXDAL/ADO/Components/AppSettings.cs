using System.Configuration;

namespace SpaceXDAL.ADO.Components
{
    public class AppSettings
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["SpaceXAPI"].ConnectionString;
    }
}
