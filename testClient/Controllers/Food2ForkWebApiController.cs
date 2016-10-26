using RestSharp;
using testClient.Models;

namespace testClient.Controllers
{
    public class Food2ForkWebApiController: BaseApiController
    {
        
        

        public Food2ForkWebApiController()
        {
            Client = new RestClient(ApiUrl.FoodToForkApiBaseUrl);
            //ApiKey = "1d66273fc6b4f51df383cb59ee6301c9";
        }

        public void Food2ForkRecipeSearch()
        {
            var request = CreateRequestFood2Fork("search?" +
                                                   "key={key}" +
                                                   "&q={query}",
                                                   Method.GET);
            var result = Client.Execute(request);
        }

        public  RestRequest CreateRequestFood2Fork(string url, Method method)
        {
            CreateRequest( url, method, null);
           // var request = new RestRequest(url, method);
            request.AddHeader("X-Mashape-Key", "FVTzYVARqzmshQZlbwS6aOxIq5z7p1HOaXijsnmtZWSuZk08Gw");
            request.AddParameter("query", "chicken wings", ParameterType.UrlSegment);
            request.AddParameter("key", ApiKeys.Food2ForkApiKey, ParameterType.UrlSegment);
            return request;
        }
    }
}
