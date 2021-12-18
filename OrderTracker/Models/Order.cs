namespace OrderTracker.Models
{
  public class Order
  {
    public string OrderDate {get;}
    public int Amount {get;}
    public int ID {get;}
    public int Price {get;}
    public string Description {get;}
    public int ParentID {get;}
    public Order(string date, int qty, int id, int pid,int price,string description)
    {
      OrderDate = date;
      Amount = qty;
      ID = id;
      ParentID = pid;
      Price = price;
      Description = description;
    }
  }
}