using System.Data.Entity.ModelConfiguration;

namespace poki.Models.Configuration
{
  public class GroupsConfig : EntityTypeConfiguration<poki.Models.ModelsDB.Groups>
  {
    public GroupsConfig()
    {
      Property(p => p.Name).IsRequired();
      Property(p => p.CreationDate).IsRequired();
      
    }
  }
}