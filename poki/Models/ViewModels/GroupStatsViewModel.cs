using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace poki.Models.ViewModels
{

  public class GroupStatsViewModel
  {
    public GroupStatsViewModel()
    {
      Labels = new List<string>();
      OcenaWlasna = new List<decimal>();
      OcenaGrupy = new List<decimal>();
    }
    public List<string> Labels { get; set; }
    public List<decimal> OcenaWlasna { get; set; }
    public List<decimal> OcenaGrupy { get; set; }
  }
}