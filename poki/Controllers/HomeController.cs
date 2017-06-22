using System.Linq;
using System.Web.Mvc;
using poki.Logic;


namespace poki.Controllers
{
  public class HomeController : Controller
  {
    PokiDBContext db = new PokiDBContext();
    public ActionResult Index()
    {
      ViewBag.Title = "Home Page";
      SystemLogin user = new SystemLogin();
      ViewBag.Message = user.Get();

      return View();
    }
    [HttpGet]
    public ActionResult GetPersons()
    {
      db.Persons.ToList();
     
      return View();
    }
  }
}
