using Entities;

namespace Contracts;

public interface IPaymentItemsRepositoryBase
{
    IEnumerable<PaymentItems> GetPaymentItems(Guid PaymentId);
    public void AddItem(PaymentItems paymentItems);
}