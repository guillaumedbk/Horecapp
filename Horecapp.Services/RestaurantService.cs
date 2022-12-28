using Horecapp.Domain.Interfaces;
using Horecapp.Domain.Models;

namespace Horecapp.Services;

public class RestaurantService: CrudService<Restaurant>, ICrudService<Restaurant>
{
    public RestaurantService(ICrudRepository<Restaurant> crudRepository) : base(crudRepository)
    {
    }
}