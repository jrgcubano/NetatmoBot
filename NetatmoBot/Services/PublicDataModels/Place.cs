namespace NetatmoBot.Services.PublicDataModels
{
    public class Place
    {
        public decimal[] location { get; set; }
        public decimal altitude { get; set; }
        public string timezone { get; set; }

        // Present in module list.
        public string country { get; set; }
        public bool trust_location { get; set; }

        public string bssid { get; set; }
        public string city { get; set; }

        public string geoip_city { get; set; }

        public string meteoalarm_area { get; set; }
    }
}