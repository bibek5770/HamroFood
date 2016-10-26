
using Models.GoogleMapsApiModels.Request;
using RestSharp;

namespace Services.ExternalApiServices
{
    public class GoogleApiService:BaseApiService
    {
        public GoogleApiService(string baseUrl)
        {
            Client = new RestClient(baseUrl);
        }
       // public void CreateRequest(string url, Method method)
       // {
       //    CreateRequest(url, method,ApiKeys.GooglePlacesApiKey);
       // }

        public void AddParametersTextSearch(GooglePlaceTextSearchModel searchParameters)
        {

            Request.AddParameter("searchFor", searchParameters.Query, ParameterType.UrlSegment);
            Request.AddParameter("rankby", searchParameters.rankby, ParameterType.UrlSegment);
            Request.AddParameter("location",$"{searchParameters.geometry.location.Lat},{searchParameters.geometry.location.Lng}"
                                            ,ParameterType.UrlSegment);
            Request.AddParameter("type", searchParameters.placeType, ParameterType.UrlSegment);
            Request.AddParameter("radius", searchParameters.Radius, ParameterType.UrlSegment);
            Request.AddParameter("opennow", searchParameters.OpenNow, ParameterType.UrlSegment);
            Request.AddParameter("maxprice", searchParameters.Price.MaxPrice, ParameterType.UrlSegment);
            Request.AddParameter("minprice", searchParameters.Price.MaxPrice, ParameterType.UrlSegment);   
            //request.AddParameter("radius", 500000, ParameterType.UrlSegment);
            //"30.504373,-90.47694"  restauran
        }

        public IRestResponse GetSearchResults()
        {
           var response= Client.Execute(Request);
            return response;
        }
    }
}
