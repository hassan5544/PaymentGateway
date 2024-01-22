using Contracts;

namespace Repository;

public class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;
    private readonly Lazy<IPaymentRepositoryBase> _paymentRepository ;
    private readonly Lazy<IPaymentItemsRepositoryBase> _paymentItemsRepository;

    public RepositoryManager(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
        _paymentRepository = new Lazy<IPaymentRepositoryBase>(() => new PaymentRepositoryBase(repositoryContext));
        _paymentItemsRepository = new Lazy<IPaymentItemsRepositoryBase>(() => new PaymentItemsRepositoryBase(repositoryContext));
    }


    public IPaymentRepositoryBase PaymentRepositoryBase => _paymentRepository.Value;
    public IPaymentItemsRepositoryBase PaymentItemsRepositoryBase => _paymentItemsRepository.Value;
}