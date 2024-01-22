using Entities;

namespace ApplicationContracts;

public interface IPaymentService
{
    public IEnumerable<Payment> GetAllPayments();
    public void AddPayment(Payment payment);
    public Payment ViewPayment(Guid PaymentId);

}