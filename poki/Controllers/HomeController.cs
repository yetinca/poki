﻿using System.Web.Mvc;
using poki.Logic;
using poki.Models;
using poki.Models.ViewModels;

namespace poki.Controllers
{
  public class HomeController : Controller
  {
    
    private readonly IUnitOfWork _unitOfWork;

    private PokiContext db = new PokiContext();

    public HomeController()
    {
      _unitOfWork = new UnitOfWork(db);
    }

    //public HomeController(IUnitOfWork unitOfWork)
    //{
    //  //_unitOfWork = unitOfWork;
    //  this._unitOfWork = unitOfWork;
     
    //}


    public ActionResult Index()
    {

      SystemLogin sys = new SystemLogin();
      ViewBag.login = sys.Get();

      return View();
    }

    public ActionResult Participants()
    {
      var osoby = _unitOfWork.Persons.GetAll();

      return View(osoby);
    }
    
    public ActionResult GetPersons(int id)
    {
       return View(_unitOfWork.Persons.GetPersonResults(id));
    }

    public ActionResult GetGroups(int id) {

      var grupy = _unitOfWork.groups.GetGroupWithNumber(id);
      return View(grupy);
        }

    public ActionResult GroupsWithDetails()
    {

      return View(_unitOfWork.groups.GetAll());
    }

    public ActionResult RegisterParticipant()
    {
      return View();
    }
    [HttpPost]
    public ActionResult AddParticipant(RegisterParticipant model)
    {
      if (ModelState.IsValid)
      {
        Persons per = new Persons();

        per.Name = model.Name;
        per.PESEL = model.PESEL;
        _unitOfWork.Persons.Add(per);
        _unitOfWork.Save();
        return View("Participants");
      }
      return View("RegisterParticipant",model);
      
    }
  }
}
