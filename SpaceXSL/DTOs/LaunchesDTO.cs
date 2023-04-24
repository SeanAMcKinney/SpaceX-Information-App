using SpaceXDAL.EntityModles;

namespace SpaceXSL.DTOs
{
    public class LaunchesDTO
    {
        public Fairings? Fairings { get; set; }
        public LaunchLinks? Links { get; set; }
        public string? Rocket { get; set; }
        public bool? Success { get; set; }
        public Failure[]? Failures { get; set; }
        public string? Details { get; set; }
        public string[]? Crew { get; set; }
        public string[]? Ships { get; set; }
        public string[]? Capsules { get; set; }
        public string[]? Payloads { get; set; }
        public string? Launchpad { get; set; }
        public int? Flight_number { get; set; }
        public string? Name { get; set; }
        public DateTime? Date_local { get; set; }
        public bool Upcoming { get; set; }
        public string? Id { get; set; }
    }

    public class Fairings
    {
        public bool? Reused { get; set; }
        public bool? Recovery_attempt { get; set; }
        public bool? Recovered { get; set; }
    }

    public class LaunchLinks
    {
        public Reddit? Reddit { get; set; }
        public string? Presskit { get; set; }
        public string? Webcast { get; set; }
        public string? Youtube_id { get; set; }
        public string? Article { get; set; }
        public string? Wikipedia { get; set; }
    }

    public class Reddit
    {
        public string? Campaign { get; set; }
        public string? Launch { get; set; }
        public string? Media { get; set; }
        public string? Recovery { get; set; }
    }
}
