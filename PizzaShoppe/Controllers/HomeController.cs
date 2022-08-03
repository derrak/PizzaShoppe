
using Microsoft.AspNetCore.Mvc;

namespace PizzaShoppe.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}