namespace testClient.Models.GoogleApi.Request
{
    public class GooglePlaceRadarSearchParameters
    {
        //required
        public Geometry geometry { get; set; }
        public string Radius { get; set; }
        public string Key { get; set; }
        
        //end required
        public PriceLimit Price { get; set; }

        public string PageToken { get; set; }

  
        //[Required]
        public OutputType Output { get; set; } =OutputType.Json;
    }
}
