using RestSharp;

namespace testClient.Controllers
{
    public  abstract class BaseApiController
    {
        public RestRequest request;
        public RestClient Client;
        public void CreateRequest(string url, Method method, string ApiKey)
        {
            request = new RestRequest(url, method);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("key", ApiKey, ParameterType.UrlSegment);
        }
    }
}
