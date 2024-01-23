using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity
{
    private readonly RepositoryContext _repositoryContext;

    public RepositoryBase(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
    }
    public IEnumerable<T> FindAll()
    {
        return _repositoryContext.Set<T>();
    }

    public IQueryable<T> GetByMasterKey(Guid id)
    {
        return _repositoryContext.Set<T>().Where(x => x.Id == id);
    }
    public void Create(T entity)
    {
        _repositoryContext.Set<T>().Add(entity);
    }

    public void Update(T entity)
    {
        _repositoryContext.Set<T>().Update(entity);
    }

    public void Delete(T entity)
    {
        _repositoryContext.Set<T>().Remove(entity);
    }
}