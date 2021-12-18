using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vendor
  {
    public static List<Vendor> vendorList = new List<Vendor>{};
    public string Name { get; }
    public List<Order> OrderList { get; }
    public int ID {get;}
    public Vendor(string name)
    {
      Name = name;
      ID = vendorList.Count;
      OrderList = new List<Order>{};
      Vendor.vendorList.Add(this);
    }
    public void AddOrder(string date, int qty)
    {
      OrderList.Add(new Order(date, qty,OrderList.Count,ID));
    }
    public Order Find(int ID)
    {
      return OrderList[ID];
    }
    public List<Order> GetAllOrders()
    {
      return OrderList;
    }
    public static List<Vendor> GetAllVendors()
    {
      return vendorList;
    }
    public static Vendor GetById(int id)
    {
      return vendorList[id];
    }
  }
}