using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace poki.Models
{
  public class ProperResultsQuestion
  {
    public int ID { get; set; }

    public int ProperResultID { get; set; }

    public int AssessedParticipantsInGroupsID { get; set; }

    public int QuestionID { get; set; }

    public byte? QuestionValue { get; set; }

    [StringLength(500)]
    public string QuestionText { get; set; }

    public virtual ParticipantsInGroup AssessedParticipantsInGroups { get; set; }

    public virtual ProperResult ProperResults { get; set; }

    public virtual Question Questions { get; set; }

  }
}