namespace Models
{
    public class Geometry
    {

        public Location location { get; set; }
        public ViewPort viewPort { get; set; }
   

    }
    public class ViewPort
    {
        public Location Norteast { get; set; }
        public Location Southwest { get; set; }
    }
    public class Location
    {
        public string Lat { get; set; } = "30.504373";
        public string Lng { get; set; } = "-90.47694";
    }


}
