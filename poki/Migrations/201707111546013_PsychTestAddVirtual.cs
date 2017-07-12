namespace poki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PsychTestAddVirtual : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TestPsych", "PersonID", c => c.Int(nullable: false));
            AddColumn("dbo.TestPsych", "Persons_ID", c => c.Int());
            CreateIndex("dbo.TestPsych", "Persons_ID");
            AddForeignKey("dbo.TestPsych", "Persons_ID", "dbo.Persons", "ID");
            DropColumn("dbo.TestPsych", "Person");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TestPsych", "Person", c => c.Int(nullable: false));
            DropForeignKey("dbo.TestPsych", "Persons_ID", "dbo.Persons");
            DropIndex("dbo.TestPsych", new[] { "Persons_ID" });
            DropColumn("dbo.TestPsych", "Persons_ID");
            DropColumn("dbo.TestPsych", "PersonID");
        }
    }
}
