using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace poki.Models.ModelsDB
{
[Table("groups")]
  [Serializable]
  public class Groups: BaseEntity

  {
    public Groups()
    {
      Participants = new HashSet<Participants>();
    }
    public string Name { get; set; }
    public DateTime CreationDate { get; set; }
    public virtual ICollection<Participants> Participants { get; set; }
  }
}