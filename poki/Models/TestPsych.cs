using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace poki.Models
{
  public class TestPsych
  {
    public TestPsych()
    {
          
    }

    public int ID { get; set; }
    public int PersonID { get; set; }
    public virtual Persons Persons { get; set; }
    public int Result { get; set; }


  }
}