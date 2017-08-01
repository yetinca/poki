using System.ComponentModel.DataAnnotations;

namespace poki.Models.ViewModels
{
  public class RegisterParticipant
  {
    [Required]
    [Display(Name="Nazwisko")]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    [StringLength(11)]
    [RegularExpression("/d{11}")]
    public string PESEL { get; set; }

    [Required]
    [Display(Name = "Ksywka")]
    [StringLength(10)]
    public string NickName { get; set; }
  }
}