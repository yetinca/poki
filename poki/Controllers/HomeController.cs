using System.Web.Mvc;
using poki.Models;

namespace poki.Controllers
{
  public class HomeController : Controller
  {
    PokiContext db = new PokiContext();

    private readonly IUnitOfWork _unitOfWork;
  

    public HomeController()
    {

    }

    public HomeController(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
     
    }

    public ActionResult Index()
    {
      var osoby = _unitOfWork.Persons.GetAll();

      return View(osoby);
    }
    
    public ActionResult GetPersons()
    {


      return View(_unitOfWork.Persons.GetPersonResults(1));
    }
  }
}
