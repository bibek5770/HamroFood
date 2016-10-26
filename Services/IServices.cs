
using Services.ExternalApiServices;
using Services.Mapper;
using Services.RestSharpRequestBuilder;

namespace Services
{
    public interface IServices
    {
        MapperServices MapperService { get; }
        RequestBuilders RequestBuilder { get; }
        GoogleApiService GoogleApiTextSearchService { get; }
        GoogleApiService GoogleApiRadarSearchApiService { get; }

        SpoonacularApiServices SpoonacularApiServiceComplexSearch { get; }
    }
}
