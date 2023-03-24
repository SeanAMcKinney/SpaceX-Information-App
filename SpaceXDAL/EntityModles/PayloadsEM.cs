using System;

namespace SpaceXDAL.EntityModles
{

    public class Payloads
    {
        public PayloadsEM[] Property1 { get; set; }
    }

    public class PayloadsEM
    {
        public Dragon dragon { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public bool reused { get; set; }
        public string launch { get; set; }
        public string[] customers { get; set; }
        public int?[] norad_ids { get; set; }
        public string[] nationalities { get; set; }
        public string[] manufacturers { get; set; }
        public float? mass_kg { get; set; }
        public float? mass_lbs { get; set; }
        public string orbit { get; set; }
        public string reference_system { get; set; }
        public string regime { get; set; }
        public float? longitude { get; set; }
        public float? semi_major_axis_km { get; set; }
        public float? eccentricity { get; set; }
        public float? periapsis_km { get; set; }
        public float? apoapsis_km { get; set; }
        public float? inclination_deg { get; set; }
        public float? period_min { get; set; }
        public float? lifespan_years { get; set; }
        public DateTime? epoch { get; set; }
        public float? mean_motion { get; set; }
        public float? raan { get; set; }
        public float? arg_of_pericenter { get; set; }
        public float? mean_anomaly { get; set; }
        public string id { get; set; }
    }

    public class Dragon
    {
        public string capsule { get; set; }
        public float? mass_returned_kg { get; set; }
        public float? mass_returned_lbs { get; set; }
        public int? flight_time_sec { get; set; }
        public string manifest { get; set; }
        public bool? water_landing { get; set; }
        public bool? land_landing { get; set; }
    }

}
