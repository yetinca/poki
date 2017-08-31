using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace poki.Models.ViewModels
{
  public class SaveTest1ViewModel
  {
    public IEnumerable<SaveTest1ViewModelAnswer> Answers { get; set; }
    public DateTime StartTime { get; set; }
    public int AssessingParticipantID { get; set; }

  }
  public class SaveTest1ViewModelAnswer
  {
    public int ParticipantInGroupID { get; set; }
    public int QuestionID { get; set; }
    public int? QuestionValue { get; set; }
    public string QuestionText { get; set; }

  }
}