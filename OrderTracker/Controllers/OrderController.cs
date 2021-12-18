using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;
namespace OrderTracker.Controllers
{
    public class OrderController : Controller
    {
      [HttpGet("/Vendor/{id}/order/new")]
      public ActionResult New(int id)
      {
        Vendor target = Vendor.GetById(id);
        return View(target);
      }
      [HttpPost("/Vendor/{id}/order")]
      public ActionResult Create(int id, string orderDate, int quantity)
      {
        Vendor.vendorList[id].AddOrder(orderDate,quantity);
        int orderId = Vendor.vendorList[id].OrderList.Count-1;
        Order input = Vendor.GetById(id).Find(orderId);
        return RedirectToAction("Show","Vendor",new {id=id});
      }
      [HttpGet("/Vendor/{ID}/order/{orderId}")]
      public ActionResult Show(int ID, int orderId)
      {
        Order input = Vendor.GetById(ID).Find(orderId);
        return View(input);
      }
    }
}