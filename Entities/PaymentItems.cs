namespace Entities;

public class PaymentItems : BaseEntity
{
    public string ItemName { get; protected set; }
    public decimal Price { get; protected set; }



    protected PaymentItems(string itemName , decimal price)
    {
        ItemName = itemName;
        Price = price;
    }

    public void SetItemName(string newItemName)
    {
        ItemName = newItemName;
    }

    public void SetItemPrice(decimal newPrice)
    {
        Price = newPrice;
    }


    public PaymentItems CreateNewItem(string itemName, decimal price)
    {
        PaymentItems newPaymentItem = new PaymentItems(itemName , price);
        return newPaymentItem;
    }

}