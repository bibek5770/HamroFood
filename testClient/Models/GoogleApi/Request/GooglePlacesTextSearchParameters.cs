namespace testClient.Models.GoogleApi.Request
{
    public class GooglePlaceTextSearchParameters
    { 
        public Geometry geometry { get; set; }
        public string Radius { get; set; } = "50000";

        public PriceLimit Price { get; set; } 

        public PlaceType placeType { get; } = PlaceType.restaurant;
        //[Required]
        public string Key { get; set; }

        public OutputType Output { get; set; } = OutputType.Json;

        public string Query { get; set; }
        public RankBy rankby { get; set; }= RankBy.Prominence;

        public bool OpenNow { get; set; } 
    }



   

    

}

