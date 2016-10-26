namespace Models.GoogleMapsApiModels.Request
{
    public class GooglePlaceRadarSearchModel
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
