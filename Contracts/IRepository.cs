using Entities;

namespace Contracts;

public interface IRepository<TEntiy> where TEntiy : BaseEntity
{
    void Insert(TEntiy entity);
    void Update(TEntiy entity);
    void Delete(Guid id);
    List<TEntiy> GetAll();
}