using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTracker.Models;

namespace OrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void Vendor_ConstructorCreatesAnObject_True()
    {
      Vendor myVendor = new Vendor("Bob");
      Assert.IsNotNull(myVendor);
    }
    [TestMethod]
    public void Vendor_assignsNameToSelf_True()
    {
      Vendor myVendor = new Vendor("Bob");
      Assert.AreEqual("Bob",myVendor.Name);
    }
    [TestMethod]
    public void AddOrder_AddsAnOrder_True()
    {
      Vendor myVendor = new Vendor("Bob");
      myVendor.AddOrder("12/17/21",420);
      Assert.AreNotEqual(0,myVendor.OrderList.Count);
    }
    [TestMethod]
    public void AddOrder_AddsTheCorrectOrder_True()
    {
      Vendor myVendor = new Vendor("Bob");
      myVendor.AddOrder("12/17/21",420);
      Assert.AreEqual(myVendor.OrderList[0].OrderDate, "12/17/21");
      Assert.AreEqual(myVendor.OrderList[0].Amount,420);
    }
    

  }
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void Order_ConstructorCreatesObject_True()
    {
      Order myOrder = new Order("12/17/21",15,1);
      Assert.IsNotNull(myOrder);
    }
    [TestMethod]
    public void Order_ConstructorAssignsCorrectValues_True()
    {
      Order myOrder = new Order("12/17/21",15,1);
      Assert.AreEqual("12/17/21",myOrder.OrderDate);
      Assert.AreEqual(15, myOrder.Amount);
    }
  }
}