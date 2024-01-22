using Contracts;
using Entities;

namespace Repository;

public class PaymentRepositoryBase : RepositoryBase<Payment> , IPaymentRepositoryBase
{
    public PaymentRepositoryBase(RepositoryContext context) : base(context)
    {
    }
    public IEnumerable<Payment> GetAllPayment()
    {
        return FindAll().OrderBy(c => c.PaymentDate).ToList();
    }

    public void AddNewPayment(Payment payment)
    {
        Create(payment);
    }


}