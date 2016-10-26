using RestSharp;
using testClient.Models.GoogleApi.Request;

namespace testClient.Controllers
{
    public class GooglePlacesApiController: BaseApiController
    {
        private static string ApiKey;

        public GooglePlacesApiController(string baseUrl)
        {
            Client =new RestClient(baseUrl);
            ApiKey = "AIzaSyASvo4HuOhMVnf4GkWxMvm0jm_siMz65gk";
        }
        public void CreateRequest(string url, Method method)
        {
            CreateRequest(url,method, ApiKey);
        }

        public void AddParameters(GooglePlaceTextSearchParameters searchParameters)
        {
            if (searchParameters != null && request!=null)
            {
                request.AddParameter("searchFor", searchParameters.Query, ParameterType.UrlSegment);
                request.AddParameter("rankby", searchParameters.rankby, ParameterType.UrlSegment);
                request.AddParameter("location",
                    string.Format("{0},{1}", searchParameters.geometry.location.Lat,
                                              searchParameters.geometry.location.Lng),
                    ParameterType.UrlSegment);
                request.AddParameter("type", searchParameters.placeType, ParameterType.UrlSegment);
                request.AddParameter("radius", searchParameters.Radius, ParameterType.UrlSegment);
                request.AddParameter("opennow", searchParameters.OpenNow, ParameterType.UrlSegment);
                request.AddParameter("maxprice", searchParameters.Price.MaxPrice, ParameterType.UrlSegment);
                request.AddParameter("minprice", searchParameters.Price.MaxPrice, ParameterType.UrlSegment);

            }
            //request.AddParameter("radius", 500000, ParameterType.UrlSegment);
            //"30.504373,-90.47694"  restauran
        }

        
    }
}
