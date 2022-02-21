using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OfoodData;

namespace pluralsight.Pages.Restaurant
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IRestaurantData restaunrantData;

        // public int MyProperty { get; set; }
        public string Message { get; set; }
        public IEnumerable<Ofood.Restaurant> Restaurants { get; set; }

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
        }

        public void OnGet()  
        {
            Message = "Hello, World!";
            Restaurants = restaunrantData.GetAll();
        }
    }
}  