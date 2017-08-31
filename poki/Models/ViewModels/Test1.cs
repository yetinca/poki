using System;
using System.Collections.Generic;

namespace poki.Models.ViewModels
{
  public class Test1
  {
    public IEnumerable<Question> Questions { get; set; }
    public Groups Group { get; set; }
    public int AssessingParticipantID { get; set; }
    public DateTime StartTime { get; set; }

  }
}