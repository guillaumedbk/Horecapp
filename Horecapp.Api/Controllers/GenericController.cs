using Horecapp.Domain.Interfaces;
using Horecapp.Domain.Models;
using Horecapp.Domain.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Horecapp.Api.Controllers;

public class GenericController<T>: ControllerBase where T : class, IStoredObject
{
    //Controller needs to call the Service
    private readonly ICrudService<T> _crudService;

    public GenericController(ICrudService<T> crudService)
    {
        _crudService = crudService;
    }
    
    //GetAll method to retrieve all items from specific table T
    [HttpGet, ProducesResponseType(StatusCodes.Status200OK), ProducesResponseType(StatusCodes.Status404NotFound)]
    public List<T> GetAll()
    {
        return _crudService.GetAll();
    }
    
    //GetById method to retrieve one item from T table 
    [HttpGet("{id:int}"), ProducesResponseType(StatusCodes.Status200OK), ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetById(int id)
    {
        var result = _crudService.GetById(id);

        if (result is null) return NotFound();
        //TODO retrieve with DTO
        return Ok(result);
    }
    
    //Add method to create new T item
    [HttpPost]
    public async Task<T> Add([FromBody] T t)
    {
        throw new NotImplementedException();
    }
    
    //Put
    [HttpPut("{id:int}")]
    public T Put(int id, [FromBody] T t)
    {
        throw new NotImplementedException();
    }
    
    //Patch
    [HttpPatch("{id:int}")]
    public T Patch(int id, [FromBody] JsonPatchDocument<T> patchDocument)
    {
        throw new NotImplementedException();
    }

    //Delete method to delete a Restaurant item
    [HttpDelete("{id:int}")]
    public ActionResult<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }
}