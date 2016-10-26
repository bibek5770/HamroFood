using Models.GoogleMapsApiModels.Request;
using Models;
using Models.HamroFoodApi;

namespace Services.Mapper
{
 public class MapperServices
    {
        public GooglePlaceTextSearchModel GooglePlacesTextSearch(RestaurantSearchByTextModel restaurantSearchByTextModel)
        {
            if (restaurantSearchByTextModel != null)
            {
                GooglePlaceTextSearchModel googlePlacesTextSearchModel = new GooglePlaceTextSearchModel();             
                googlePlacesTextSearchModel.Price = new PriceLimit()
                {
                    MaxPrice = restaurantSearchByTextModel.MaxPrice.ToString(),
                    //TODO: include min price in the parameter model
                    MinPrice = "0"

                };
                googlePlacesTextSearchModel.geometry = new Geometry()
                {
                    location = new Location()
                    {
                        Lat = (restaurantSearchByTextModel?.CurrentLocation?.Lat) ?? "30.5043",
                        Lng = (restaurantSearchByTextModel?.CurrentLocation?.Lng) ?? "-90.4769"
                    }
                };
                googlePlacesTextSearchModel.Radius = restaurantSearchByTextModel.Radius ?? "50000";
                googlePlacesTextSearchModel.OpenNow = restaurantSearchByTextModel.OpenNow;
                googlePlacesTextSearchModel.Query = restaurantSearchByTextModel.Query ?? "beer";

;                return googlePlacesTextSearchModel;
            }
            return null;
        }

        public GooglePlaceTextSearchModel GooglePlacesTextSearch(string query, string cuisineType, string categoryType, 
            string latitude, string longitude, string radius, string maxPrice, string maxCalories, string openNow)
        {
            GooglePlaceTextSearchModel googlePlacesTextSearchModel = new GooglePlaceTextSearchModel();
            googlePlacesTextSearchModel.Price = new PriceLimit()
            {
                MaxPrice = maxPrice ?? "4",
                //TODO: include min price in the parameter model
                MinPrice = "0"

            };
            googlePlacesTextSearchModel.geometry = new Geometry()
            {
                location = new Location()
                {
                    Lat = latitude ?? "30.5043",
                    Lng = longitude ?? "-90.4769"
                }
            };
            googlePlacesTextSearchModel.Radius = radius ?? "50000";
            googlePlacesTextSearchModel.OpenNow = openNow ?? "false";
            googlePlacesTextSearchModel.Query = query;
            return googlePlacesTextSearchModel;
          }
        }
}

        
            
    











//Price = new PriceLimit()
//{
//    MaxPrice = restaurantSearchByTextModel.MaxPrice,
//                        //TODO: include min price in the parameter model
//                        MinPrice = 0

//                    },
//                    geometry = new Geometry()
//{
//    location = new Location()
//    {
//        Lat = restaurantSearchByTextModel.CurrentLocation.Lat ?? "30.504373",
//        Lng = restaurantSearchByTextModel.CurrentLocation.Lng ?? "-90.47694"
//    }
//                    },
//                    Radius = restaurantSearchByTextModel.Radius ?? "50000",
//                    OpenNow = restaurantSearchByTextModel.OpenNow,
//                    Query = restaurantSearchByTextModel.Query ?? "beer"

//                };