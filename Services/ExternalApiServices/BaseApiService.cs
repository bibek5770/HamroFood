using RestSharp;

namespace Services.ExternalApiServices
{
    public abstract class BaseApiService
    { 
            public RestRequest Request;
            public RestClient Client;
            public void CreateRequest(string url, Method method, string apiKey)
            {
                Request = new RestRequest(url, method);
                Request.AddHeader("Accept", "application/json");
                Request.AddHeader("Content-Type", "application/json; charset=utf-8");
                Request.RequestFormat = DataFormat.Json;
                Request.AddParameter("key", apiKey, ParameterType.UrlSegment);
            }

           
    }
}
