using Horecapp.Domain.Models;

namespace Horecapp.Domain.Interfaces;

public interface ICrudService<T> where T : class, IStoredObject
{
    List<T> GetAll();
    T GetById(int id);
    T Add(T obj);
    T Put(int id, T obj);
    T Patch(int id);
    bool Delete(int id);
} 