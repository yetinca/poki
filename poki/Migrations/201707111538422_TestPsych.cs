namespace poki.Migrations
{
  using System.Data.Entity.Migrations;

  public partial class TestPsych : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TestPsych",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Person = c.Int(nullable: false),
                        Result = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TestPsych");
        }
    }
}
