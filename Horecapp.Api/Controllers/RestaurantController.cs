using Horecapp.Domain.Interfaces;
using Horecapp.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Horecapp.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RestaurantController: GenericController<Restaurant> 
{
    public RestaurantController(ICrudService<Restaurant> crudService) : base(crudService)
    {
    }
}