using System.ComponentModel.DataAnnotations;

namespace poki.Models
{
  public class DescriptionToResults
  {
    public int ID { get; set; }
    [Required]
    public int ResultsID { get; set; }
    [Required]
    public int ParticipantID { get; set; }
    [Required]
    public string Text { get; set; }

    public virtual Results Results{ get; set; }

    public virtual Participants Participants { get; set; }
  }
}