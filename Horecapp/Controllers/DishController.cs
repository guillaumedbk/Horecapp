using Horecapp.Models;

namespace Horecapp.Controllers;

public class DishController: GenericController<Dish>
{
    //dbContext for the interaction with database
    public DishController(HorecappDbContext dbContext): base(dbContext) {}
}