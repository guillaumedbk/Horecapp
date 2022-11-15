using Horecapp.Domain.Models;
using Horecapp.Domain.Models;

namespace Horecapp.Api.Controllers;

public class DishController: GenericController<Dish>
{
    //dbContext for the interaction with database
    public DishController(HorecappDbContext dbContext): base(dbContext) {}
}