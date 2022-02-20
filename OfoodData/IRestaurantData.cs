using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using Ofood;

namespace OfoodData
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
               new Restaurant{Id = 1, Name = "Ronnie's Scott", Location = "Maryland",  Cuisine = CuisineType.Indian},
               new Restaurant{Id = 2, Name = "Jen's kitchen", Location = "ColliersWoood",  Cuisine = CuisineType.Indian},
               new Restaurant{Id = 3, Name = "Bountiful cow", Location = "Red lion",  Cuisine = CuisineType.Indian}
               
            };

        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                orderby r.Name
                select r; 


        }
        }
    }