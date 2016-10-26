using System.Collections.Generic;
using Models.GoogleMapsApiModels.Response;

namespace Models.HamroFoodApi
{
 public class FoodModel
    {
        public string Id { get; set; }
        public string SpoonacularCuisineType { get; set; }
        public string EdamanCuisineType { get; set; }
        public  IList<string> CategoriesList { get; set; }
        public string TotalCalories { get; set; }
        public string Name { get; set; }
        public Ingredients FoodIngredients { get; set; }
        public string Price { get; set; }
        public string IconSource { get; set; }
        public IList<Photos> PhotosList { get; set; }

        public string Quantity { get; set; }


    }
}
