using Entities;

namespace Contracts;

public interface IUntiOfWork
{
    void Commit();
    void Rollback();
    IRepositoryManager Repository();
}