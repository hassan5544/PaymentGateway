using Contracts;
using Entities;

namespace Repository;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity
{
    private RepositoryContext RepositoryContext;

    public RepositoryBase(RepositoryContext repositoryContext)
    {
        RepositoryContext = repositoryContext;
    }
    public IEnumerable<T> FindAll()
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> GetByMasterKey(Guid Id)
    {
        throw new NotImplementedException();
    }
    public void Create(T entity)
    {
        throw new NotImplementedException();
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(T entity)
    {
        throw new NotImplementedException();
    }
}