using System;
using System.Web.Http;
using Models;
using Models.SpoonacularApiModels.Response;
using Newtonsoft.Json;
using RestSharp;
using Services;

namespace FoodApi.Controllers
{
    public class FoodController : ApiController
    {
        private readonly IServices _services;

        public FoodController()
        {
            _services=new Services.Services();
        }
        [HttpGet]
        public IHttpActionResult GetDetailInformation(string foodName)
        {
            if (String.IsNullOrEmpty(foodName))
            {
                return BadRequest("Invalid Request. Name of the dish is required");
            }
            var response = BuildAndExecuteSpoonacularServiceComplexSearch(foodName);
            var result = JsonConvert.DeserializeObject<SpooncacularApiComplexSearchDTO>(response.Content);
            //todo:logic here for storing data and machine learning
            var backToJson = JsonConvert.SerializeObject(result);
            if (result == null)
            {
                return BadRequest("Invalid Request");
            }
            return Ok(backToJson);
        }

        private IRestResponse BuildAndExecuteSpoonacularServiceComplexSearch(string foodName)
        {

            _services.SpoonacularApiServiceComplexSearch.CreateRequest("searchComplex" +
                                                                      "?addRecipeInformation=true&limitLicense=false&number=10&offset=0&query={foodName}&ranking=1"
                , Method.GET, ApiKeys.SpoonacularApiKey);
            _services.SpoonacularApiServiceComplexSearch.AddHeadersAndParameters(foodName);
            var response = _services.SpoonacularApiServiceComplexSearch.GetSearchResults();
            return response;
        }
    }
}
