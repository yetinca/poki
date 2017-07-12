namespace poki.Models
{
  using System;
  using System.Data.Entity;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Linq;

  public partial class PokiContext : DbContext
  {
    public PokiContext()
        : base("name=PokiConnStr")
    {
    }

    public virtual DbSet<groups> groups { get; set; }
    public virtual DbSet<participants> participants { get; set; }
    public virtual DbSet<Persons> Persons { get; set; }
    public virtual DbSet<results> results { get; set; }
    public virtual DbSet<TestPsych> TestPsych { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Entity<groups>()
          .HasMany(e => e.participants)
          .WithRequired(e => e.groups)
          .HasForeignKey(e => e.GrupaID)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<Persons>()
          .Property(e => e.NickName)
          .IsFixedLength();

      modelBuilder.Entity<Persons>()
          .Property(e => e.PESEL)
          .IsFixedLength();

      modelBuilder.Entity<Persons>()
          .HasMany(e => e.participants)
          .WithRequired(e => e.Persons)
          .HasForeignKey(e => e.PersonID)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<Persons>()
          .HasMany(e => e.results)
          .WithRequired(e => e.Persons)
          .HasForeignKey(e => e.ParticipantID)
          .WillCascadeOnDelete(false);
    }
  }
}
