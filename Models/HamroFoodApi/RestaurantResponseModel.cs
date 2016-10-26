using System.Collections.Generic;
using Models.GoogleMapsApiModels.Response;

namespace Models.HamroFoodApi
{
   public class RestaurantResponseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string GooglePlaceId { get; set; }
        public string GooglePlaceFormattedAddress { get; set; }
        public Location GoogleLocation { get; set; }
        public string GoogleRating { get; set; }
        public string YelpRating { get; set; }
        public string Icon { get; set; }
        public IList<Photos> PhotosList { get; set; }
        public OpeningHours OpeningHours { get; set; }
        public string GoogleNextPageToken { get; set; }

    }    
}
