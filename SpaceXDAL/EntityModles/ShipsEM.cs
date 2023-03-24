namespace SpaceXDAL.EntityModles
{

    public class Ships
    {
        public ShipsEM[] Property1 { get; set; }
    }

    public class ShipsEM
    {
        public object last_ais_update { get; set; }
        public string legacy_id { get; set; }
        public string model { get; set; }
        public string type { get; set; }
        public string[] roles { get; set; }
        public int? imo { get; set; }
        public int? mmsi { get; set; }
        public int? abs { get; set; }
        public int? _class { get; set; }
        public int? mass_kg { get; set; }
        public int? mass_lbs { get; set; }
        public int? year_built { get; set; }
        public string home_port { get; set; }
        public string status { get; set; }
        public object speed_kn { get; set; }
        public object course_deg { get; set; }
        public float? latitude { get; set; }
        public float? longitude { get; set; }
        public string link { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public bool active { get; set; }
        public string[] launches { get; set; }
        public string id { get; set; }
    }

}
