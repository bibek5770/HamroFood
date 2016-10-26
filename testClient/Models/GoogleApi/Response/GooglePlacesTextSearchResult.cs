using System.Collections.Generic;
using Newtonsoft.Json;

namespace testClient.Models.GoogleApi.Response
{
    public class GooglePlacesTextSearchResult
    {

        public IList<Results> results { get; set; }
        [JsonProperty("status")]
        public System.Net.HttpStatusCode StatusCode { get; set; }
    }

    public class Results
    {
        [JsonProperty("formatted_Address")]
        public string FormattedAddress { get; set; }

        [JsonProperty("geometry")]
        public Geometry Geometry { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("opening_hours")]
        public OpeningHours OpeningHours { get; set; }

        [JsonProperty("photos")]
        public IList<Photos> PhotosList { get; set; }

        [JsonProperty("place_id")]
        public string Place_Id { get; set; }


        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }


        [JsonProperty("types")]
        public IList<string> PlaceType { get; set; }

    }


    public class Photos
    {

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("html_attributions")]
        public IList<string> HtmlAttribution { get; set; }


        [JsonProperty("photo_reference")]
        public string PhotoReference { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

    }

    public class OpeningHours
    {

        [JsonProperty("open_now")]
        public string IsOpenNow { get; set; }

        [JsonProperty("weekday_text")]
        public IList<string> WeekdayTest { get; set; }
    }
}
