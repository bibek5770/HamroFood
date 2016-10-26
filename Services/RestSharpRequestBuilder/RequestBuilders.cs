using Models;
using Models.GoogleMapsApiModels.Request;
using RestSharp;

namespace Services.RestSharpRequestBuilder
{
    public class RequestBuilders
    {
        public RestRequest request;
        public static RestClient Client;

        public void CreateRequest(string url, Method method,string ApiKey)
        {
            request = new RestRequest(url, method);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("key", ApiKey, ParameterType.UrlSegment);
        }

        public void BuildGoogleApiTextSearchRequest(GooglePlaceTextSearchModel googlePlaceTextSearchModel)
        {
            Client = new RestClient(ApiUrl.GooglePlacesApiTextSearchUrl);
            CreateRequest("json?"
                                // + "keyword={searchFor}" // only for  radarsearch
                                + "&query={searchFor}" //include only for textsearch
                               + "&location={location}"
                                + "&radius={radius}" //must include if location is to be included
                                + "&type={type}" //include for radar
                            //  +"&rankby={rankby}"  //only include for radarSearch
                                + "&key={key}"
                             // +"&opennow"
                               , Method.GET
                               ,ApiKeys.GooglePlacesApiKey);

            // googlePlacesSearch.AddParameters(GooglePlacesRequestModel_Test);
            //todo: move to a client request execute service provider
            request.AddParameter("searchFor", googlePlaceTextSearchModel.Query, ParameterType.UrlSegment);
            request.AddParameter("rankby", googlePlaceTextSearchModel.rankby, ParameterType.UrlSegment);
            request.AddParameter("location",
                string.Format("{0},{1}", googlePlaceTextSearchModel.geometry.location.Lat,
                                          googlePlaceTextSearchModel.geometry.location.Lng),
                ParameterType.UrlSegment);
            request.AddParameter("type", googlePlaceTextSearchModel.placeType, ParameterType.UrlSegment);
            request.AddParameter("radius", googlePlaceTextSearchModel.Radius, ParameterType.UrlSegment);
            request.AddParameter("opennow", googlePlaceTextSearchModel.OpenNow, ParameterType.UrlSegment);
            request.AddParameter("maxprice", googlePlaceTextSearchModel.Price.MaxPrice, ParameterType.UrlSegment);
            request.AddParameter("minprice", googlePlaceTextSearchModel.Price.MaxPrice, ParameterType.UrlSegment);
            var result =Client.Execute(request);
            var xxx = "test";
        }

        public void BuildGoogleApiRadarSearchRequest()
        {

        }

        public void BuildSpoonacularApiRequest()
        {

        }

        public void BuildEdamanApiRequest()
        {

        }

    }
}
