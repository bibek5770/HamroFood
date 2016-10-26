namespace testClient.Models.GoogleApi.Request
{
    class BaseRequest
    {
        public Geometry Loc { get; set; }
        public string Radius { get; set; }
        public string Key { get; set; }
        public PriceLimit Price { get; set; }     
        public OutputType output { get; set; } = OutputType.Json;
    }
}
