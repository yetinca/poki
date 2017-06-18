using System.Data.Entity;
using System.Web.Http.Results;
using System.Web.Mvc;
using poki.Logic;
using poki.Models;

namespace poki.Controllers
{
  public class HomeController : Controller
  {
    public readonly DataContext dbContext = new DataContext();
    public ActionResult Index()
    {
      ViewBag.Title = "Home Page";
      SystemLogin user = new SystemLogin();
      ViewBag.Message = user.Get();

      return View();
    }
    [HttpGet]
    public JsonResult GetPersons()
    {
      var list = dbContext.Persons;

      return Json(list,JsonRequestBehavior.AllowGet);
    }
  }
}
