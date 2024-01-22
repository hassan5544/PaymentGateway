using Entities;

namespace Contracts;

public interface IRepositoryBase<T> where T : BaseEntity
{
    IEnumerable<T> FindAll();
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
}