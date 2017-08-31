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
      this.Configuration.LazyLoadingEnabled = false;
    }

    public virtual DbSet<Groups> Groups { get; set; }
    public virtual DbSet<ParticipantsInGroup> ParticipantsInGroup { get; set; }
    public virtual DbSet<Participants> Participants { get; set; }
    public virtual DbSet<Results> Results { get; set; }
    public virtual DbSet<TestPsych> TestPsych { get; set; }
    public virtual DbSet<AccessLogins> AccessLogins { get; set; }
    public virtual DbSet<DescriptionToResults> DescriptionToResults { get; set; }
    public virtual DbSet<Question> Questions { get; set; }
    public virtual DbSet<ProperResult> ProperResults { get; set; }
    public virtual DbSet<ProperResultsQuestion> ProperResultsQuestions { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      
      modelBuilder.Entity<Groups>()
          .HasMany(e => e.ParticipantsInGroup)
          .WithRequired(e => e.Groups)
          .HasForeignKey(e => e.GroupsID)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<Participants>()
          .Property(e => e.NickName)
          .IsFixedLength();

      modelBuilder.Entity<Participants>()
          .Property(e => e.PESEL)
          .IsFixedLength();

      modelBuilder.Entity<Participants>()
          .HasMany(e => e.ParticipantsInGroup)
          .WithRequired(e => e.Participants)
          .HasForeignKey(e => e.ParticipantsID)
          .WillCascadeOnDelete(false);

      //modelBuilder.Entity<Results>()
      //    .HasMany(e => e.ParticipantsInGroup)
      //    .WithRequired(e => e.)
      //    .HasForeignKey(e => e.ParticipantID)
      //    .WillCascadeOnDelete(false);
    }
  }
}
