using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.SpoonacularApiModels.Response
{
   public class ClassifyCuisine
    {
        [JsonProperty("cuisine")]
        public string CuisineType { get; set; }

        [JsonProperty("cuisines")]
        public IList<string> OtherPossibleCuisine { get; set; }

        [JsonProperty("confidence")]
        public int Possibility { get; set; }
    }
}
