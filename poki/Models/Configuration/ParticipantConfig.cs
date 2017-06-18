using System.Data.Entity.ModelConfiguration;

namespace poki.Models.Configuration
{
  public class ParticipantConfig :EntityTypeConfiguration<poki.Models.ModelsDB.Participants>
  {
    public ParticipantConfig()
    {
      HasRequired(p => p.Groups).WithMany(t => t.Participants);
      HasRequired(p => p.Persons).WithMany(t => t.Participants);
    }
  }
}