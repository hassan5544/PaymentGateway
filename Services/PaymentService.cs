using ApplicationContracts;
using Contracts;
using Entities;

namespace Services;

public class PaymentService : IPaymentService
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IUntiOfWork _untiOfWork;

    public PaymentService(IUntiOfWork untiOfWork)
    {
        _untiOfWork = untiOfWork;
        _repositoryManager = _untiOfWork.Repository();
    }
    public IEnumerable<Payment> GetAllPayments()
    {
        return _repositoryManager.PaymentRepositoryBase.GetAllPayment();
    }

    public void AddPayment(Payment payment)
    {
        _repositoryManager.PaymentRepositoryBase.AddNewPayment(payment);
        foreach (var item in payment.Items)
        {
            _repositoryManager.PaymentItemsRepositoryBase.AddItem(item);
        }
        _untiOfWork.Commit();
    }

    public Payment ViewPayment(Guid PaymentId)
    {
        throw new NotImplementedException();
    }
}