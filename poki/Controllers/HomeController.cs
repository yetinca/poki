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
   
      return View();
    }
    
    public ActionResult GetPersons()
    {
      
     
      return View(_unitOfWork.Resolve<Persons>());
    }
  }
}
