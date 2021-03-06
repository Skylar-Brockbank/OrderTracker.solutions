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
      Vendor myVendor = new Vendor("Bob","description");
      Assert.IsNotNull(myVendor);
    }
    [TestMethod]
    public void Vendor_assignsNameToSelf_True()
    {
      Vendor myVendor = new Vendor("Bob","description");
      Assert.AreEqual("Bob",myVendor.Name);
    }
    [TestMethod]
    public void AddOrder_AddsAnOrder_True()
    {
      Vendor myVendor = new Vendor("Bob","description");
      myVendor.AddOrder("12/17/21",420,69,"description");
      Assert.AreNotEqual(0,myVendor.OrderList.Count);
    }
    [TestMethod]
    public void AddOrder_AddsTheCorrectOrder_True()
    {
      Vendor myVendor = new Vendor("Bob","description");
      myVendor.AddOrder("12/17/21",420,69,"description");
      Assert.AreEqual(myVendor.OrderList[0].OrderDate, "12/17/21");
      Assert.AreEqual(myVendor.OrderList[0].Amount,420);
    }
    [TestMethod]
    public void Find_RetrievesAnOrder_True()
    {
      Vendor myVendor = new Vendor("Bob","description");
      myVendor.AddOrder("12/17/21",420,69,"description");
      Assert.AreEqual(myVendor.Find(0),myVendor.OrderList[0]);
    }

  }
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void Order_ConstructorCreatesObject_True()
    {
      Order myOrder = new Order("12/17/21",15,1,0,50,"description");
      Assert.IsNotNull(myOrder);
    }
    [TestMethod]
    public void Order_ConstructorAssignsCorrectValues_True()
    {
      Order myOrder = new Order("12/17/21",15,1,0,50,"description");
      Assert.AreEqual("12/17/21",myOrder.OrderDate);
      Assert.AreEqual(15, myOrder.Amount);
    }
  }
}