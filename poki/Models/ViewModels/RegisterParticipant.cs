using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace poki.Models.ViewModels
{
  public class RegisterParticipant
  {
    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    [StringLength(11)]
    [RegularExpression("/d{11}")]
    public string PESEL { get; set; }
  }
}