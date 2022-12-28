using Horecapp.Domain.Interfaces;
using Horecapp.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Horecapp.Repository;

public class CrudRepository<T>: ICrudRepository<T> where T : class, IStoredObject
{
    //Repository needs the DB Context
    private readonly HorecappDbContext _dbContext;
    
    public CrudRepository(HorecappDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public List<T> GetAll()
    {
        return _dbContext.Set<T>().ToList();
    }

    public T GetById(int id)
    {
        return _dbContext.Set<T>().SingleOrDefault(t => t.Id == id)!;
    }

    public T Add(T obj)
    {
        throw new NotImplementedException();
    }

    public T Put(int id, T obj)
    {
        throw new NotImplementedException();
    }

    public T Patch(int id)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }
}