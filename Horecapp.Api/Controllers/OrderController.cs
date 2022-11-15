using Horecapp.Domain.Models;

namespace Horecapp.Api.Controllers;

public class OrderController: GenericController<Order>
{
    public OrderController(HorecappDbContext dbContext) : base(dbContext)
    {
    }
}