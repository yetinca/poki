using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace poki.Models.ModelsApp
{
  public class ResultsApp
  {
    public int ParticipantID { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int Pytanie1 { get; set; }
    public int Pytanie2 { get; set; }
    public int Pytanie3 { get; set; }
  }
}