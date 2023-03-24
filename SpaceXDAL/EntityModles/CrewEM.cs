namespace SpaceXDAL.EntityModles
{

    public class Crew
    {
        public CrewEM[] Property1 { get; set; }
    }

    public class CrewEM
    {
        public string name { get; set; }
        public string agency { get; set; }
        public string image { get; set; }
        public string wikipedia { get; set; }
        public string[] launches { get; set; }
        public string status { get; set; }
        public string id { get; set; }
    }

}
