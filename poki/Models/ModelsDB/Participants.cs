using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace poki.Models.ModelsDB
{
    [Table("participants")]
    [Serializable]
  public class Participants : BaseEntity
  {
    public int GrupaID { get; set; }
    public virtual Groups Groups { get; set; }
    public int PersonID { get; set; }
    public virtual Persons Persons { get; set; }
  }
}