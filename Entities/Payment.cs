namespace Entities;

public class Payment : BaseEntity
{
    public DateTime PaymentDate { get; protected set; }
    public decimal TotalAmount { get; protected set; }
    public List<PaymentItems> Items { get; protected set; }
}