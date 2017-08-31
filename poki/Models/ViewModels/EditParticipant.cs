using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace poki.Models.ViewModels
{
  public class EditParticipant
  {
    public int ID { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    [StringLength(10)]
    public string NickName { get; set; }

    public byte[] Picture { get; set; }

    [Required]
    [StringLength(11)]
    public string PESEL { get; set; }
  }
}