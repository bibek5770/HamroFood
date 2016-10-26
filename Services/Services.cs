using Models;
using Services.ExternalApiServices;
using Services.Mapper;
using Services.RestSharpRequestBuilder;

namespace Services
{
    public class Services: IServices
    {
        //todo change to IServices
        public MapperServices MapperService;
        public RequestBuilders RequestBuilder;
        public GoogleApiService GoogleApiTextSearchService;
        public GoogleApiService GoogleApiRadarSearchApiService;
        public SpoonacularApiServices SpoonacularApiServiceComplexSearch;

        public Services()
        {
            //todo:use IOC container
            MapperService = new MapperServices();
            RequestBuilder= new RequestBuilders();
            GoogleApiTextSearchService = new GoogleApiService(ApiUrl.GooglePlacesApiTextSearchUrl);
            GoogleApiRadarSearchApiService = new GoogleApiService(ApiUrl.GooglePlacesApiRadarSearchUrl);
            SpoonacularApiServiceComplexSearch = new SpoonacularApiServices(ApiUrl.SpoonacularApiComplexSearch);
        }

        MapperServices IServices.MapperService => MapperService;

        RequestBuilders IServices.RequestBuilder => RequestBuilder;

         GoogleApiService IServices.GoogleApiTextSearchService=>GoogleApiTextSearchService;
         GoogleApiService IServices.GoogleApiRadarSearchApiService=>GoogleApiRadarSearchApiService;

        SpoonacularApiServices IServices.SpoonacularApiServiceComplexSearch
            => SpoonacularApiServiceComplexSearch;
    }
}
