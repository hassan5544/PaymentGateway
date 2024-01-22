using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class UnitOfWork : IUntiOfWork
{
    private readonly RepositoryContext _context;
    private bool disposed = false;

    public UnitOfWork(RepositoryContext context)
    {
        _context = context;
    }
    public void Commit()
    {
        _context.SaveChanges();
    }
    public void Rollback()
    {
        foreach (var entry in _context.ChangeTracker.Entries())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.State = EntityState.Detached;
                    break;

                case EntityState.Modified:
                case EntityState.Deleted:
                    entry.Reload();
                    break;
            }
        }
    }
    public IRepositoryManager Repository() 
    {
        return new RepositoryManager(_context);
    }
   
}