namespace SpaceXDAL.EntityModles
{

    public class Dragons
    {
        public DragonsEM[] Property1 { get; set; }
    }

    public class DragonsEM
    {
        public Heat_Shield heat_shield { get; set; }
        public Launch_Payload_Mass launch_payload_mass { get; set; }
        public Launch_Payload_Vol launch_payload_vol { get; set; }
        public Return_Payload_Mass return_payload_mass { get; set; }
        public Return_Payload_Vol return_payload_vol { get; set; }
        public Pressurized_Capsule pressurized_capsule { get; set; }
        public Trunk trunk { get; set; }
        public Height_W_Trunk height_w_trunk { get; set; }
        public Diameter diameter { get; set; }
        public string first_flight { get; set; }
        public string[] flickr_images { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public bool active { get; set; }
        public int crew_capacity { get; set; }
        public int sidewall_angle_deg { get; set; }
        public int orbit_duration_yr { get; set; }
        public int dry_mass_kg { get; set; }
        public int dry_mass_lb { get; set; }
        public Thruster[] thrusters { get; set; }
        public string wikipedia { get; set; }
        public string description { get; set; }
        public string id { get; set; }
    }

    public class Heat_Shield
    {
        public string material { get; set; }
        public float size_meters { get; set; }
        public int temp_degrees { get; set; }
        public string dev_partner { get; set; }
    }

    public class Launch_Payload_Mass
    {
        public int kg { get; set; }
        public int lb { get; set; }
    }

    public class Launch_Payload_Vol
    {
        public int cubic_meters { get; set; }
        public int cubic_feet { get; set; }
    }

    public class Return_Payload_Mass
    {
        public int kg { get; set; }
        public int lb { get; set; }
    }

    public class Return_Payload_Vol
    {
        public int cubic_meters { get; set; }
        public int cubic_feet { get; set; }
    }

    public class Pressurized_Capsule
    {
        public Payload_Volume payload_volume { get; set; }
    }

    public class Payload_Volume
    {
        public int cubic_meters { get; set; }
        public int cubic_feet { get; set; }
    }

    public class Trunk
    {
        public Trunk_Volume trunk_volume { get; set; }
        public Cargo cargo { get; set; }
    }

    public class Trunk_Volume
    {
        public int cubic_meters { get; set; }
        public int cubic_feet { get; set; }
    }

    public class Cargo
    {
        public int solar_array { get; set; }
        public bool unpressurized_cargo { get; set; }
    }

    public class Height_W_Trunk
    {
        public float meters { get; set; }
        public float feet { get; set; }
    }

    public class Diameter
    {
        public float meters { get; set; }
        public int feet { get; set; }
    }

    public class Thruster
    {
        public string type { get; set; }
        public int amount { get; set; }
        public int pods { get; set; }
        public string fuel_1 { get; set; }
        public string fuel_2 { get; set; }
        public int isp { get; set; }
        public Thrust thrust { get; set; }
    }

    public class Thrust
    {
        public float kN { get; set; }
        public int lbf { get; set; }
    }

}
