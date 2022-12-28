using Horecapp.Domain.Interfaces;
using Horecapp.Domain.Models;

namespace Horecapp.Api.Controllers;

public class OrderController: GenericController<Order>
{
    public OrderController(ICrudService<Order> crudService) : base(crudService)
    {
    }
}