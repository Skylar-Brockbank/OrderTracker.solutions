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

  }
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void Order_ConstructorCreatesObject_True()
    {
      Order myOrder = new Order("12/17/21",15);
      Assert.IsNotNull(myOrder);
    }
    [TestMethod]
    public void Order_ConstructorAssignsCorrectValues_True()
    {
      Order myOrder = new Order("12/17/21",15);
      Assert.AreEqual("12/17/21",myOrder.OrderDate);
      Assert.AreEqual(15, myOrder.Amount);
    }
  }
}