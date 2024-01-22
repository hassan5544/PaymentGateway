namespace Contracts;

public interface IRepositoryManager
{
    public IPaymentRepositoryBase PaymentRepositoryBase { get; }
    public IPaymentItemsRepositoryBase PaymentItemsRepositoryBase { get; }
}
