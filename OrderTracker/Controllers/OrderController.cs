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
      [HttpPost("/Vendor/{id}/order/new")]
      public ActionResult Create(int id, string date, int qty)
      {
        Vendor.vendorList[id].AddOrder(date,qty);
        return RedirectToAction("Show",id,Vendor.vendorList[id].OrderList.Count-1);
      }
      [HttpGet("/Vendor/{id}/order/{Vendor.vendorList[id].OrderList.Count-1}")]
      public ActionResult Show(int id, int orderId)
      {
        int inputIds = [id,orderId];
        return View(inputIds);
      }
    }
}