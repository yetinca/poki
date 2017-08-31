using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace poki.Models
{
  public class Question
  {


    public int ID { get; set; }

    [StringLength(15)]
    public string QuestionText { get; set; }

    public int OrderNumber { get; set; }

    public bool IsDeleted { get; set; }

    public byte Type { get; set; }

    [StringLength(250)]
    public string QuestionDescription { get; set; }


  }
}