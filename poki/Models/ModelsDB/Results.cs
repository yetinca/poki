using System;

namespace poki.Models.ModelsDB
{
    [Table("results")]
    [Serializable]
  public class Results: BaseEntity
  {
    public int ParticipantID { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int Pytanie1 { get; set; }
    public int Pytanie2 { get; set; }
    public int Pytanie3 { get; set; }

    public virtual Persons Persons { get; set; }
  }
}