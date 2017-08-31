using System;
using System.Web.Mvc;
using poki.Models;
using poki.Models.ViewModels;

namespace poki.Controllers
{
  public class TestsController : Controller
  {

    private readonly IUnitOfWork _unitOfWork;

    private PokiContext db = new PokiContext();

    public TestsController()
    {
      _unitOfWork = new UnitOfWork(db);
    }



    [HttpPost]
    public ActionResult Test1Form(Test1Form model)
    {
      Results results = new Results();
      if (ModelState.IsValid)
      {
        results.Pytanie1 = model.Pytanie1;
        results.Pytanie2 = model.Pytanie2;
        results.Pytanie3 = model.Pytanie3;
        results.Pytanie4 = model.Pytanie4;
        results.Pytanie5 = model.Pytanie5;

      }
      return View("Test1Form");
    }
    public ActionResult Test1(int ID)
    {

      ParticipantsInGroup pg = _unitOfWork.ParticipantsInGroup.Get(ID);
      Test1 model = new Test1();

      model.Group = _unitOfWork.Groups.GetGroupWithParticipants(pg.GroupsID);
      model.Questions = _unitOfWork.Question.OrderedQuestions();
      model.AssessingParticipantID = pg.ParticipantsID;
      model.StartTime = DateTime.Now;




      return View(model);

    }
    [HttpPost]
    public JsonResult SaveTest1(SaveTest1ViewModel model)
    {


      ProperResult pr = new ProperResult();

      pr.AssessingParticipantsInGroupsID = model.AssessingParticipantID;
      pr.StartTime = model.StartTime;
      pr.EndTime = DateTime.Now;
      _unitOfWork.ProperResults.Add(pr);
      _unitOfWork.Save();

      foreach (var z in model.Answers)
      {
        ProperResultsQuestion prq = new ProperResultsQuestion();
        prq.ProperResultID = pr.ID;
        prq.QuestionID = z.QuestionID;
        prq.QuestionValue = (byte)z.QuestionValue;
        prq.QuestionText = z.QuestionText;
        prq.AssessedParticipantsInGroupsID = z.ParticipantInGroupID;
        _unitOfWork.ProperResultsQuestion.Add(prq);
      }

      _unitOfWork.Save();

      return Json(true);
    }

    public ActionResult GroupStats(int participantInGroupID)
    {
      
      return View(participantInGroupID);
    }
    [HttpPost]
    public JsonResult GetGroupStats(int participantInGroupID)
    {
      GroupStatsViewModel participantStats = new GroupStatsViewModel();

      participantStats.Labels.Add("p1");
      participantStats.Labels.Add("p2");
      participantStats.Labels.Add("p3");
      participantStats.Labels.Add("p4");
      participantStats.Labels.Add("p5");

      participantStats.OcenaGrupy.Add(1);
      participantStats.OcenaGrupy.Add(4);
      participantStats.OcenaGrupy.Add(5.6M);
      participantStats.OcenaGrupy.Add(7.9M);
      participantStats.OcenaGrupy.Add(2.4M);

      participantStats.OcenaWlasna.Add(1);
      participantStats.OcenaWlasna.Add(3);
      participantStats.OcenaWlasna.Add(7.6M);
      participantStats.OcenaWlasna.Add(4.9M);
      participantStats.OcenaWlasna.Add(3.4M);

      return Json(participantStats);

    }
  }
}