using Microsoft.AspNetCore.Mvc;

namespace Tamagochi.Controllers
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
