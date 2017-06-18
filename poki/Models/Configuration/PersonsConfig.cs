using System.Data.Entity.ModelConfiguration;

namespace poki.Models.Configuration
{
  public class PersonsConfig :EntityTypeConfiguration<poki.Models.ModelsDB.Persons>
  {
    public PersonsConfig()
    {
      Property(p => p.Name).IsRequired();
      Property(p => p.NickName).IsRequired();
      Property(p => p.Picture).IsOptional();
      Property(p => p.PESEL).IsRequired();
      
    }
  }
}