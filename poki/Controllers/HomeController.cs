using System;
using System.IO;
using System.Web;
using System.Web.Mvc;
using poki.App_Start;
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
      var osoby = _unitOfWork.Participants.GetAll();

      return View(osoby);
    }
    
   

    public ActionResult GroupsWithDetails(int id) {

      var grupy = _unitOfWork.Groups.GetGroupWithNumber(id);
      return View("GroupsWithDetails",grupy);
        }

    public ActionResult GetGroups()
    {

      return View("GetGroups",_unitOfWork.Groups.GetAll());
    }
    public ActionResult AddNewGroup()
    {
      return View();
    }

    public ActionResult AddGroup(AddGroupViewModel model)
    {
      Groups newGroup = new Groups();

      newGroup.Name = model.Name;
      newGroup.CreationDate = DateTime.Now;

      _unitOfWork.Groups.Add(newGroup);
      _unitOfWork.Save();

      return RedirectToAction("GetGroups");

    }

    public ActionResult RegisterParticipant()
    {
      return View();
    }
    [HttpPost]
    public ActionResult AddParticipant(RegisterParticipant model, HttpPostedFileBase image1)
    {
      if (ModelState.IsValid && image1!=null && image1.ContentLength>0)
      {
        Participants per = new Participants();

        byte[] bytes;
        using (BinaryReader br = new BinaryReader(image1.InputStream))
        {
          bytes = br.ReadBytes(image1.ContentLength);
        }
      

        per.Name = model.Name;
        per.NickName = model.NickName;
        per.PESEL = model.PESEL;
        per.Picture = bytes;
        _unitOfWork.Participants.Add(per);
        _unitOfWork.Save();
        return RedirectToAction("Participants");
      }
      return View("RegisterParticipant",model);
      
    }
    public ActionResult ParticipantsInGroup(int id)
    {
      ViewBag.nrgrupy = id;
      return View(_unitOfWork.Groups.GetGroupWithParticipants(id));
    }

    [HttpPost]
    public ActionResult DeleteParticipant(int participantID)
    {

      var par = _unitOfWork.Participants.Get(participantID);
      _unitOfWork.Participants.Remove(par);
      _unitOfWork.Save();
      return RedirectToAction("Participants");
    }

    //public ActionResult AddParticipantsToGroup(int groupID)
    //{
    //  var osoby = _unitOfWork.Persons.GetAll();
    //  var group = _unitOfWork.Groups.Get(groupID);

    //  AddParticipantsToGroupModel model = new AddParticipantsToGroupModel()
    //  {
    //    Group = group,
    //    Participants = osoby
    //  };

    //  return View(model);
    //}

    public ActionResult AvailableParticipants(int ID)
    {
      
      ViewBag.nrgrupy = ID;
      var available = _unitOfWork.ParticipantsInGroup.GetAvailableParticipants(ID);

      return View(available);
    }

    [HttpDelete]
    public ActionResult DeleteParticipantsFromAGroup(string str)
    {
      var par = db.ParticipantsInGroup.SqlQuery("Select * from ParticipantsInGroup where ParticipantID in(" + str + ")");
      _unitOfWork.ParticipantsInGroup.RemoveRange(par);
      _unitOfWork.Save();

      return RedirectToAction("ParticipantsInGroup");
    }

    public ActionResult GetParticipant (int id)
    {
      EditParticipant model =AutoMapperConfig.Mapper.Map<EditParticipant>(_unitOfWork.Participants.Get(id));

      return View("EditParticipant", model);
    }

    [HttpPost]
    public ActionResult ModifyParticipant(EditParticipant model)
    {

      Participants part = _unitOfWork.Participants.Get(model.ID);

      AutoMapperConfig.Mapper.Map<EditParticipant, Participants>(model, part);

      _unitOfWork.Save();

      return RedirectToAction("Participants");


    }

    [HttpPost]
    public JsonResult ValidatePESEL(string pesel,int groupID)
    {
      var par = _unitOfWork.ParticipantsInGroup.GetByPeselAndGroupID(pesel, groupID);

      int parID = 0;

      if (par != null)
      {
        parID = par.ID;
      }
    
      return Json(parID);
    }

    [HttpPost]

    public JsonResult AddParticipantToGroup(int groupID, int participantID)
    {
      ParticipantsInGroup newPar = new ParticipantsInGroup();

      newPar.GroupsID = groupID;
      newPar.ParticipantsID = participantID;
      _unitOfWork.ParticipantsInGroup.Add(newPar);
      _unitOfWork.Save();

      return Json(groupID);
    }
  }
}
