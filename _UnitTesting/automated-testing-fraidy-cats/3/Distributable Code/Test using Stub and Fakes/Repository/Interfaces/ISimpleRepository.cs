using System;
using System.Linq;

namespace Repository
{
  public interface ISimpleRepository<T> : IDisposable
  {
    void Save();
    IQueryable<T> Get();
    T GetById(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(int id);
    bool IsValid(T entity);
  }
}