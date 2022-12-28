using Horecapp.Domain.Interfaces;
using Horecapp.Domain.Models;

namespace Horecapp.Services;

public class CrudService<T>: ICrudService<T> where T : class, IStoredObject
{
    //Service needs to call the Repository, we do it by abstraction
    private readonly ICrudRepository<T> _crudRepository;

    public CrudService(ICrudRepository<T> crudRepository)
    {
        _crudRepository = crudRepository;
    }
    
    public List<T> GetAll()
    {
        return _crudRepository.GetAll();
    }

    public T GetById(int id)
    {
        return _crudRepository.GetById(id);
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