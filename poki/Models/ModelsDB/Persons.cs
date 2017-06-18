using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace poki.Models.ModelsDB
{[Serializable]
  public class Persons : BaseEntity
  {
    
    public string Name { get; set; }
    public string NickName { get; set; }
    public byte[] Picture { get; set; }
    public string PESEL { get; set; }

    public Persons()
    {
      Participants = new HashSet<Participants>();
      Results = new HashSet<Results>();
    }

    public virtual ICollection<Participants> Participants { get; set; }

    public virtual ICollection<Results> Results { get; set; }

  }
}