namespace OrderTracker.Models
{
  public class Order
  {
    public string OrderDate {get;}
    public int Amount {get;}
    public int ID {get;}
    public Order(string date, int qty, int id)
    {
      OrderDate = date;
      Amount = qty;
      ID = id;
    }
  }
}