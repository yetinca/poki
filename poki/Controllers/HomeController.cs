using System.Web.Mvc;
using poki.Models;

namespace poki.Controllers
{
  public class HomeController : Controller
  {
    PokiContext db = new PokiContext();
    private readonly IUnitOfWork _unitOfWork;

    public HomeController(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }

    public ActionResult Index()
    {
      //ViewBag.Title = "Home Page";
      //SystemLogin user = new SystemLogin();
      //ViewBag.Message = user.Get();
      // var query = from c in db.Persons
      //            orderby c.Name
      //            select c;
      return View();
    }
    
    public ActionResult GetPersons()
    {
      
     
      return View(_unitOfWork.Resolve<Persons>());
    }
  }
}
