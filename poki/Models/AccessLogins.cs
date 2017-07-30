using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace poki.Models
{
  public class AccessLogins
  {
    public int ID { get; set; }
    [Required]
    [StringLength(50)]
    public string Login { get; set; }

  }
}