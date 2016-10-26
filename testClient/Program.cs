using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using testClient.Controllers;
using testClient.Models;
using testClient.Models.EdamanApiModels.Response;
using testClient.Models.GoogleApi.Request;
using testClient.Models.GoogleApi.Response;
using Models.HamroFoodApi;
using testClient.Models.GoogleApi;

namespace testClient
{
    class Program
    {
        static void Main(string[] args)
        {
      
            RestaurantSearchByTextModel restaurantSearchRequest = new RestaurantSearchByTextModel()
            {
                OpenNow ="true",
                Query = "chicken "
            };
            
            //testGoogleEndPoint();
            var query = "Chicken fajita";
            RestClient Client=new RestClient("http://localhost:61774/api/restaurant");
            string url = "search?q={query}&app_id=896840d0&app_key={key}";
            RestRequest request = new RestRequest(url, Method.GET);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("key", "c9bf18dcd7c303612a47ad7a6307e772", ParameterType.UrlSegment);
            request.AddParameter("query", query, ParameterType.UrlSegment);

            var response = Client.Execute(request);//[JSON].hits.[0].recipe.label
            var jo = JObject.Parse(response.Content);
            File.WriteAllText("C:\\Users\\Bibek\\Desktop\\test", response.Content);
            var xxxxx = JsonConvert.DeserializeObject<EdamanResponseMapper>(response.Content);
            var extractedRecipte = xxxxx.Hits.Where(x => x.Recipe.Label.ToLower().Contains(query.ToLower()));

            
             var breakpointTest = "here";


    }
        public static GooglePlaceTextSearchParameters createTestModel()
        {
            GooglePlaceTextSearchParameters testGoogle = new GooglePlaceTextSearchParameters()
            {
                geometry = new Geometry(){location =new Location() { }},
                Query = "yuengling beer",
                Price = new PriceLimit(){},
                Radius = "5000",      
                rankby = RankBy.Prominence
            };
            return testGoogle;

        }

         static void testGoogleEndPoint()
        {
            var GooglePlacesRequestModel_Test = createTestModel();

            GooglePlacesApiController googlePlacesSearch
                 = new GooglePlacesApiController(ApiUrl.GooglePlacesApiTextSearchUrl);//textsearch
            //GooglePlacesApiController google = new GooglePlacesApiController(  ApiUrl.GooglePlacesApiRadarSearchUrl);//radar search
            googlePlacesSearch.CreateRequest("json?"
                                // + "keyword={searchFor}" // only for  radarsearch

                                + "&query={searchFor}" //include only for textsearch
                               + "&location={location}"
                                + "&radius={radius}" //must include if location is to be included
                                + "&type={type}" //include for radar
                                                 //  +"&rankby={rankby}"  //only include for radarSearch
                                + "&key={key}"
                               // +"&opennow"

                               , Method.GET);

            googlePlacesSearch.AddParameters(GooglePlacesRequestModel_Test);
            var result = googlePlacesSearch.Client.Execute(googlePlacesSearch.request);
            //Console.WriteLine(result.Content);
            File.WriteAllText("C:\\Users\\Bibek\\Desktop\\test.txt", result.Content);
            var response = JsonConvert.DeserializeObject<GooglePlacesTextSearchResult>(result.Content);
           // var responseByrating = response.results.OrderByDescending(x => x.Rating);
            var xxx = "xxx";
            
        }
    }
}
//{https://maps.googleapis.com/maps/api/place/textsearch/json?query=beer&location=30.504373%2C30.504373&rankby=Prominence&key=AIzaSyASvo4HuOhMVnf4GkWxMvm0jm_siMz65gk}


////testGoogleEndPoint();
//var query = "Chicken fajita";
//RestClient Client = new RestClient(ApiUrl.EdamamApiBaseUrl);
//string url = "search?q={query}&app_id=896840d0&app_key={key}";
//RestRequest request = new RestRequest(url, Method.GET);
//request.AddHeader("Accept", "application/json");
//            request.AddHeader("Content-Type", "application/json; charset=utf-8");
//            request.RequestFormat = DataFormat.Json;
//            request.AddParameter("key", "c9bf18dcd7c303612a47ad7a6307e772", ParameterType.UrlSegment);
//            request.AddParameter("query", query, ParameterType.UrlSegment);

//            var response = Client.Execute(request);//[JSON].hits.[0].recipe.label
//var jo = JObject.Parse(response.Content);
//File.WriteAllText("C:\\Users\\Bibek\\Desktop\\test", response.Content);
//            var xxxxx = JsonConvert.DeserializeObject<EdamanResponseMapper>(response.Content);
//var extractedRecipte = xxxxx.Hits.Where(x => x.Recipe.Label.ToLower().Contains(query.ToLower()));


//var breakpointTest = "here";
