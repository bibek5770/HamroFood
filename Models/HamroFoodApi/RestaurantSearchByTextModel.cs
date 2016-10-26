using System.ComponentModel.DataAnnotations;

namespace Models.HamroFoodApi
{
    public class RestaurantSearchByTextModel
    {
        [Required]
        public string Query { get; set; }
        public string CuisineType { get; set; }
        public string CategoryType { get; set; }
      //public string TotalCalories { get; set; }
        public Location CurrentLocation { get; set; }
        public string Radius { get; set; }
        public int MaxPrice { get; set; }
        public string MaxCalories { get; set; }
        public string OpenNow { get; set; } = "true";
        ///ignore allergies, allergies are permanent and will be stored in database

    }
}
