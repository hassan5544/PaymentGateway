using Entities;

namespace Contracts;

public interface IPaymentRepositoryBase
{
    public IEnumerable<Payment> GetAllPayment();
    public void AddNewPayment(Payment payment);
}