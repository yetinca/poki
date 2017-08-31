using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace poki.Models
{
  public class ProperResult
  {
    public int ID { get; set; }

    public int AssessingParticipantsInGroupsID { get; set; }

    //public int AssessedParticipantsInGroupsID { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public virtual ParticipantsInGroup AssessingParticipantsInGroups { get; set; }

    //public virtual ParticipantsInGroup AssessedParticipantsInGroups { get; set; }

    public virtual IEnumerable<ProperResultsQuestion> ProperResultsQestions { get; set; }

  }
}