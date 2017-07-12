using System.Web.Mvc;
using poki.Core;
using poki.Models;

namespace poki.Controllers
{
  public class HomeController : Controller
  {
    PokiContext db = new PokiContext();
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepository<Persons> _personsRepository;

    public HomeController(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
      _personsRepository = _unitOfWork.Resolve<Persons>();
    }

    public ActionResult Index()
    {
   
      return View();
    }
    
    public ActionResult GetPersons()
    {
      
     
      return View(_personsRepository.GetAll());
    }
  }
}
