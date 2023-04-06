using System;

namespace SpaceXDAL.EntityModles
{

    //public class StarlinkEM
    //{
    //    public Starlink[] Property1 { get; set; }
    //}

    public class Starlink
    {
        public Spacetrack spaceTrack { get; set; }
        public string launch { get; set; }
        public string version { get; set; }
        public float? height_km { get; set; }
        public float? latitude { get; set; }
        public float? longitude { get; set; }
        public float? velocity_kms { get; set; }
        public string id { get; set; }
    }

    public class Spacetrack
    {
        public string CCSDS_OMM_VERS { get; set; }
        public string COMMENT { get; set; }
        public DateTime CREATION_DATE { get; set; }
        public string ORIGINATOR { get; set; }
        public string OBJECT_NAME { get; set; }
        public string OBJECT_ID { get; set; }
        public string CENTER_NAME { get; set; }
        public string REF_FRAME { get; set; }
        public string TIME_SYSTEM { get; set; }
        public string MEAN_ELEMENT_THEORY { get; set; }
        public DateTime EPOCH { get; set; }
        public float MEAN_MOTION { get; set; }
        public float ECCENTRICITY { get; set; }
        public float INCLINATION { get; set; }
        public float RA_OF_ASC_NODE { get; set; }
        public float ARG_OF_PERICENTER { get; set; }
        public float MEAN_ANOMALY { get; set; }
        public int EPHEMERIS_TYPE { get; set; }
        public string CLASSIFICATION_TYPE { get; set; }
        public int NORAD_CAT_ID { get; set; }
        public int ELEMENT_SET_NO { get; set; }
        public int REV_AT_EPOCH { get; set; }
        public float BSTAR { get; set; }
        public float MEAN_MOTION_DOT { get; set; }
        public float MEAN_MOTION_DDOT { get; set; }
        public float SEMIMAJOR_AXIS { get; set; }
        public float PERIOD { get; set; }
        public float APOAPSIS { get; set; }
        public float PERIAPSIS { get; set; }
        public string OBJECT_TYPE { get; set; }
        public string RCS_SIZE { get; set; }
        public string COUNTRY_CODE { get; set; }
        public string LAUNCH_DATE { get; set; }
        public string SITE { get; set; }
        public string DECAY_DATE { get; set; }
        public int DECAYED { get; set; }
        public int FILE { get; set; }
        public int GP_ID { get; set; }
        public string TLE_LINE0 { get; set; }
        public string TLE_LINE1 { get; set; }
        public string TLE_LINE2 { get; set; }
    }

}
