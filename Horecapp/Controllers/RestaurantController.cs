using Horecapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Horecapp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RestaurantController: GenericController<Restaurant> 
{
    //dbContext for the interaction with database
    public RestaurantController(HorecappDbContext dbContext): base(dbContext) {}
}