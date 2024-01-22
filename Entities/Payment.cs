namespace Entities;

public class Payment : BaseEntity
{
    public DateTime PaymentDate { get; protected set; }
    public List<PaymentItems> Items { get; protected set; } 
    public decimal TotalAmount {
        get
        {
           return Items.Sum(x => x.Price);
        }
    }


    protected Payment()
    {
        
    }

    public Payment CreateNewPayment()
    {
        Payment NewPayment = new Payment();
        NewPayment.Items = new List<PaymentItems>();
        PaymentDate = DateTime.Now;
        return NewPayment;
    }

    public void AddItem(PaymentItems item)
    {
        bool check = CheckIfItemExists(item);
        if(!check)
            Items.Add(item);
        else
        {
            throw new AggregateException("Item Already Exists");
        }
    }
    
    private bool CheckIfItemExists(PaymentItems item)
    {
        return Items.Any(x => x.ItemName == item.ItemName);
    }
}