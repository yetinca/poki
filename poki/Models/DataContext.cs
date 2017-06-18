using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using poki.Models.ModelsDB;

namespace poki.Models
{
  public class DataContext : DbContext
  {
    public DataContext() : base("ConnectionString")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }
    public static DataContext Create()
    {
      return new DataContext();
    }

    public DbSet<Groups> Groups { get; set; }

    public DbSet<Participants> Participants { get; set; }

    public DbSet<Persons> Persons { get; set; }

    public DbSet<Results> Results { get; set; }
  }
}