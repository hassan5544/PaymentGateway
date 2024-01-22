using Contracts;
using Entities;

namespace Repository;

public class PaymentItemsRepositoryBase : RepositoryBase<PaymentItems> , IPaymentItemsRepositoryBase
{
    public PaymentItemsRepositoryBase(RepositoryContext context) : base(context)
    {
    }

    public IEnumerable<PaymentItems> GetPaymentItems(Guid PaymentId)
    {
        return GetByMasterKey(PaymentId);
    }

    public void AddItem(PaymentItems paymentItems)
    {
        Create(paymentItems);
    }
}