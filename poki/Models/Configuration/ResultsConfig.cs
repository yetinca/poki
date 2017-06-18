using System.Data.Entity.ModelConfiguration;

namespace poki.Models.Configuration
{
  public class ResultsConfig: EntityTypeConfiguration<poki.Models.ModelsDB.Results>
  {
    public ResultsConfig()
    {
      Property(p => p.StartTime).IsRequired();
      Property(p => p.EndTime).IsRequired();
      Property(p => p.Pytanie1).IsRequired();
      Property(p => p.Pytanie2).IsRequired();
      Property(p => p.Pytanie3).IsRequired();

      HasRequired(p => p.Persons).WithMany(t => t.Results);
    }
  }
}