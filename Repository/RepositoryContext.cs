using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class RepositoryContext :DbContext
{
    public RepositoryContext(DbContextOptions<RepositoryContext> options) :base(options)
    {
        
    }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<PaymentItems> PaymentItems { get; set; }
}