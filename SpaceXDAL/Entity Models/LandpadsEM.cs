namespace SpaceXDAL.EntityModles
{

    //public class Landpads
    //{
    //    public LandpadsEM[] Property1 { get; set; }
    //}

    public class LandpadsEM
    {
        public LandpadImages images { get; set; }
        public string name { get; set; }
        public string full_name { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public string locality { get; set; }
        public string region { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public int landing_attempts { get; set; }
        public int landing_successes { get; set; }
        public string wikipedia { get; set; }
        public string details { get; set; }
        public string[] launches { get; set; }
        public string id { get; set; }
    }

    public class LandpadImages
    {
        public string[] large { get; set; }
    }

}
