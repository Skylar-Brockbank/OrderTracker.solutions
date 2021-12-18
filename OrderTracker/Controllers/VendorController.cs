using Microsoft.AspNetCore.Mvc;
using OrderTracker.Models;
namespace OrderTracker.Controllers
{
    public class VendorController : Controller
    {

      [HttpGet("/vendor")]
      public ActionResult Index()
      {
        return View(Vendor.GetAllVendors());
      }
      [HttpGet("/vendor/new")]
      public ActionResult New()
      {
        return View();
      }
      [HttpPost("/vendor")]
      public ActionResult Create(string vendorName)
      {
        new Vendor(vendorName);
        return RedirectToAction("Index");
      }
      [HttpGet("/vendor/{id}")]
      public ActionResult Show(int id)
      {
        Vendor target = Vendor.GetById(id);
        return View(target);
      }
    }
}