using System.Collections.Generic;
using Ofood;

namespace OfoodData
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        public IEnumerable<Restaurant> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}     