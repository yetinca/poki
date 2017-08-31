using System;

namespace poki.Models.ViewModels
{
  public class Test1Form
  {
    public int ParticipantsInGroupID { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public short Pytanie1 { get; set; }

    public short Pytanie2 { get; set; }

    public short Pytanie3 { get; set; }

    public short Pytanie4 { get; set; }

    public short Pytanie5 { get; set; }

    public int ResultsID { get; set; }

    public int ParticipantID { get; set; }

    public string Text { get; set; }
  }
}