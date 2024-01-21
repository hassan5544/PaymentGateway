using Contracts;
using Entities;

namespace Repository;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    public void Insert(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void Update(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<TEntity> GetAll()
    {
        throw new NotImplementedException();
    }
}