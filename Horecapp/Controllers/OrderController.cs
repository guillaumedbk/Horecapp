using Horecapp.Models;

namespace Horecapp.Controllers;

public class OrderController: GenericController<Order>
{
    public OrderController(HorecappDbContext dbContext) : base(dbContext)
    {
    }
}