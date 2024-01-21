namespace Entities;

public class PaymentItems : BaseEntity
{
    public string ItemName { get; set; }
    public decimal Price { get; set; }
}