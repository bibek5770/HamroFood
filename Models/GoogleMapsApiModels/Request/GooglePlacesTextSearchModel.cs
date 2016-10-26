using System.ComponentModel.DataAnnotations;

namespace Models.GoogleMapsApiModels.Request
{
    public class GooglePlaceTextSearchModel
    { 
        
        public Geometry geometry { get; set; }
        public string Radius { get; set; } = "50000";

        public PriceLimit Price { get; set; } 

        public PlaceType placeType { get; } = PlaceType.restaurant;
        //[Required]
       // public string Key { get; set; }

        public OutputType Output { get; set; } = OutputType.Json;

        [Required]
        public string Query { get; set; }
        public RankBy rankby { get; set; }= RankBy.Prominence;

        public string OpenNow { get; set; } 
    }
       
}

