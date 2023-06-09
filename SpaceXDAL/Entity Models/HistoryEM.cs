﻿using System;

namespace SpaceXDAL.EntityModles
{

    //public class History
    //{
    //    public HistoryEM[] Property1 { get; set; }
    //}

    public class HistoryEM
    {
        public HistoryLinks links { get; set; }
        public string title { get; set; }
        public DateTime event_date_utc { get; set; }
        public int event_date_unix { get; set; }
        public string details { get; set; }
        public string id { get; set; }
    }

    public class HistoryLinks
    {
        public string article { get; set; }
    }

}
