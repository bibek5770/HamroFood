using System;
using System.Web;
using System.Web.Http;
using Models;
using Newtonsoft.Json;
using RestSharp;
using Services;
using Models.GoogleMapsApiModels.Request;
using Models.GoogleMapsApiModels.Response;

namespace FoodApi.Controllers
{
    public class RestaurantController : ApiController
    {
        private readonly IServices _services;

        public RestaurantController()
        {
            _services = new Services.Services();
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult FindRestaurantsByFilters()
        {
            var query = Request.RequestUri.Query;
            var queryParams = HttpUtility.ParseQueryString(query);

            //get the parametes from the URI and pass it to GooglePlacesTextSearch to obtain a Google request model
            var googlePlaceTextSearchModel = _services.MapperService.GooglePlacesTextSearch(
                queryParams["Query"], 
                queryParams["CuisineType"], 
                queryParams["CategoryType"],
                queryParams[ "Latitude"],
                queryParams["Longitude"],
                queryParams["Radius"],
                queryParams["MaxPrice"],
                queryParams["MaxCalories"],
                queryParams["OpenNow"]);
          // Validate(googlePlaceTextSearchModel);
             if (String.IsNullOrEmpty(googlePlaceTextSearchModel.Query)==false)
            {
                var response = BuildAndExecuteGoogleApiTextSearchService(googlePlaceTextSearchModel);
                var result = JsonConvert.DeserializeObject<GooglePlacesTextSearchResult>(response.Content);
                //todo:logic here for storing data and machine learning
                var backToJson = JsonConvert.SerializeObject(result);
                if (result == null)
                {
                    return BadRequest("Invalid Request");
                }
                return Ok(backToJson);
            }
        //var errors = string.Join(" | ", ModelState.Values
        //.SelectMany(v => v.Errors)
        //.Select(e => e.ErrorMessage));
        //    return BadRequest(errors);
            return BadRequest("Query parameter is required");
        }

        private IRestResponse BuildAndExecuteGoogleApiTextSearchService(GooglePlaceTextSearchModel googlePlaceTextSearchModel)
        {
            //  var test = services.RequestBuilder.BuildGoogleApiTextSearchRequest(googlePlaceTextSearchModel);
            _services.GoogleApiTextSearchService.CreateRequest("json?"
                                // only for  radarsearch
                                // + "keyword={searchFor}" 
                                //include only for textsearch
                                + "&query={searchFor}" 
                               + "&location={location}"
                                //must include if location is to be included
                                + "&radius={radius}"
                                //include for radar
                                + "&type={type}" 
                                //only include for radarSearch
                                //  +"&rankby={rankby}"  
                                + "&key={key}"

                                //if(openNow==false) +"&opennow"
                               , Method.GET
                               , ApiKeys.GooglePlacesApiKey);
            _services.GoogleApiTextSearchService.AddParametersTextSearch(googlePlaceTextSearchModel);
            var response = _services.GoogleApiTextSearchService.GetSearchResults();
            return response;
        }
    }
}
