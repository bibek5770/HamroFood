using System.Collections.Generic;

namespace Models.SpoonacularApiModels.Response
{

    public class SpoonacularComplexSearchResponse
    {
        public IList<Result> results { get; set; }
        public string baseUri { get; set; }
        public int offset { get; set; }
        public int number { get; set; }
        public int totalResults { get; set; }
        public int processingTimeMs { get; set; }
    }

    public class Result
    {
        public bool vegetarian { get; set; }
        public bool vegan { get; set; }
        public bool glutenFree { get; set; }
        public bool dairyFree { get; set; }
        public bool veryHealthy { get; set; }
        public bool cheap { get; set; }
        public bool veryPopular { get; set; }
        public bool sustainable { get; set; }
        public int weightWatcherSmartPoints { get; set; }
        public string gaps { get; set; }
        public bool lowFodmap { get; set; }
        public bool ketogenic { get; set; }
        public bool whole30 { get; set; }
        public int servings { get; set; }
        public int preparationMinutes { get; set; }
        public int cookingMinutes { get; set; }
        public string sourceUrl { get; set; }
        public string spoonacularSourceUrl { get; set; }
        public int aggregateLikes { get; set; }
        public string creditText { get; set; }
        public string sourceName { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public int readyInMinutes { get; set; }
        public string image { get; set; }
        public string imageType { get; set; }
        public IList<string> cuisines { get; set; }
        public int calories { get; set; }
        public string protein { get; set; }
        public string fat { get; set; }
        public string carbs { get; set; }
    }

    public class SpooncacularApiComplexSearchDTO
    {
        public IList<ResultDTO> results { get; set; }
    }

    public class ResultDTO { 

        public string baseUri { get; set; }
        public int totalResults { get; set; }
        public int servings { get; set; }
        public string carbs { get; set; }
        public int calories { get; set; }
        public IList<string> cuisines { get; set; }
        public string image { get; set; }
        public bool sustainable { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public bool glutenFree { get; set; }
        public bool dairyFree { get; set; }

        public int aggregateLikes { get; set; }

    }
}
