using Horecapp.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Horecapp.Controllers;

public class GenericController<T>: ControllerBase where T : class, IStoredObject
{
    //dbContext for the interaction with database
    protected HorecappDbContext DbContext;

    public GenericController(HorecappDbContext dbContext)
    {
        DbContext = dbContext;
    }
    
    //GetAll method to retrieve all items from specific table T
    [HttpGet]
    public List<T> GetAll()
    {
        return DbContext.Set<T>().ToList();
    }
    
    //GetById method to retrieve one item from T table 
    [HttpGet("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<T>> GetById(int id)
    {
        var result = await DbContext.Set<T>().SingleOrDefaultAsync(t => t.Id == id);

        if (result == null)
        {
            return NotFound("Object not found");
        }
        return result;
    }
    
    //Add method to create new T item
    [HttpPost]
    public async Task<T> Add([FromBody] T t)
    {
        var result = await DbContext.Set<T>().AddAsync(t);
        await DbContext.SaveChangesAsync();
        return result.Entity;
    }
    
    //Put
    [HttpPut("{id:int}")]
    public T Put(int id, [FromBody] T t)
    {
        t.Id = id;
        var entityEntry = DbContext.Attach(t);
        entityEntry.State = EntityState.Modified;
        DbContext.SaveChanges();
        return t;
    }
    
    //Patch
    [HttpPatch("{id:int}")]
    public T Patch(int id, [FromBody] JsonPatchDocument<T> patchDocument)
    {
        var baseObject = DbContext.Set<T>().Find(id);
        patchDocument.ApplyTo(baseObject);
        DbContext.SaveChanges();
        return baseObject;
    }

    //Delete method to delete a Restaurant item
    [HttpDelete("{id:int}")]
    public ActionResult<bool> Delete(int id)
    {
        var t = DbContext.Set<T>().SingleOrDefault(t => t.Id == id);
        if (t == null)
        {
            return BadRequest("The object you try to delete doesn't exist");
        }

        DbContext.Set<T>().Remove(t);
        DbContext.SaveChanges();
        return Ok("Successfully deleted");
    }
}