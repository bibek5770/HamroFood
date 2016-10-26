using Models;
using RestSharp;

namespace Services.ExternalApiServices
{
    public class SpoonacularApiServices: BaseApiService
    {
        public SpoonacularApiServices(string baseUrl)
        {
            Client = new RestClient(baseUrl);
        }

        public void AddHeadersAndParameters(string foodName)
        {
            Request.AddHeader("X-Mashape-Key", ApiKeys.SpoonacularApiKey);
            Request.AddParameter("foodName", foodName, ParameterType.UrlSegment);

        }
        public IRestResponse GetSearchResults()
        {
            var response = Client.Execute(Request);
            return response;
        }
    }
}
