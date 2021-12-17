namespace OrderTracker.Models
{
  public class Order
  {
    public string OrderDate {get;}
    public int Amount {get;}
    public Order(string date, int qty)
    {
      OrderDate = date;
      Amount = qty;
    }
  }
}