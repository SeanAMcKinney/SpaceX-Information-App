using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceXDAL.EntityModles
{

    //public class Rockets
    //{
    //    public RocketsEM[] Property1 { get; set; }
    //}

    public class RocketsEM
    {
        public Height height { get; set; }
        public RocketDiameter diameter { get; set; }
        public Mass mass { get; set; }
        public First_Stage first_stage { get; set; }
        public Second_Stage second_stage { get; set; }
        public Engines engines { get; set; }
        public Landing_Legs landing_legs { get; set; }
        public Payload_Weights[] payload_weights { get; set; }
        public string[] flickr_images { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public bool active { get; set; }
        public int stages { get; set; }
        public int boosters { get; set; }
        public int cost_per_launch { get; set; }
        public int success_rate_pct { get; set; }
        public string first_flight { get; set; }
        public string country { get; set; }
        public string company { get; set; }
        public string wikipedia { get; set; }
        public string description { get; set; }
        public string id { get; set; }
    }

    public class Height
    {
        public float meters { get; set; }
        public float feet { get; set; }
    }

    public class RocketDiameter
    {
        public float meters { get; set; }
        public float feet { get; set; }
    }

    public class Mass
    {
        public int kg { get; set; }
        public int lb { get; set; }
    }

    public class First_Stage
    {
        public Thrust_Sea_Level thrust_sea_level { get; set; }
        public Thrust_Vacuum thrust_vacuum { get; set; }
        public bool reusable { get; set; }
        public int engines { get; set; }
        public float fuel_amount_tons { get; set; }
        public int? burn_time_sec { get; set; }
    }

    public class Thrust_Sea_Level
    {
        public int kN { get; set; }
        public int lbf { get; set; }
    }

    public class Thrust_Vacuum
    {
        public int kN { get; set; }
        public int lbf { get; set; }
    }

    public class Second_Stage
    {
        public RocketThrust thrust { get; set; }
        public RocketPayloads payloads { get; set; }
        public bool reusable { get; set; }
        public int engines { get; set; }
        public float fuel_amount_tons { get; set; }
        public int? burn_time_sec { get; set; }
    }

    public class RocketThrust
    {
        public int kN { get; set; }
        public int lbf { get; set; }
    }

    public class RocketPayloads
    {
        public Composite_Fairing composite_fairing { get; set; }
        public string option_1 { get; set; }
    }

    public class Composite_Fairing
    {
        public Height1 height { get; set; }
        public Diameter1 diameter { get; set; }
    }

    public class Height1
    {
        public float? meters { get; set; }
        public float? feet { get; set; }
    }

    public class Diameter1
    {
        public float? meters { get; set; }
        public float? feet { get; set; }
    }

    public class Engines
    {
        public Isp isp { get; set; }
        public Thrust_Sea_Level1 thrust_sea_level { get; set; }
        public Thrust_Vacuum1 thrust_vacuum { get; set; }
        public int number { get; set; }
        public string type { get; set; }
        public string version { get; set; }
        public string layout { get; set; }
        public int? engine_loss_max { get; set; }
        public string propellant_1 { get; set; }
        public string propellant_2 { get; set; }
        public float thrust_to_weight { get; set; }
    }

    public class Isp
    {
        public int sea_level { get; set; }
        public int vacuum { get; set; }
    }

    public class Thrust_Sea_Level1
    {
        public int kN { get; set; }
        public int lbf { get; set; }
    }

    public class Thrust_Vacuum1
    {
        public int kN { get; set; }
        public int lbf { get; set; }
    }

    public class Landing_Legs
    {
        public int number { get; set; }
        public string material { get; set; }
    }

    public class Payload_Weights
    {
        public string id { get; set; }
        public string name { get; set; }
        public int kg { get; set; }
        public int lb { get; set; }
    }

}
