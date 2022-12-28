using Horecapp.Domain.Interfaces;
using Horecapp.Domain.Models;
using Horecapp.Domain.Models;

namespace Horecapp.Api.Controllers;

public class DishController: GenericController<Dish>
{
    public DishController(ICrudService<Dish> crudService) : base(crudService)
    {
    }
}