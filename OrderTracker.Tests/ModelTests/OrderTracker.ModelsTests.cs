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
}