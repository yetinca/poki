namespace poki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssessedParticipant : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProperResults", "AssessedParticipantsInGroupsID", "dbo.ParticipantsInGroups");
            DropIndex("dbo.ProperResults", new[] { "AssessedParticipantsInGroupsID" });
            AddColumn("dbo.ProperResultsQuestions", "AssessedParticipantsInGroupsID", c => c.Int(nullable: false));
            CreateIndex("dbo.ProperResultsQuestions", "AssessedParticipantsInGroupsID");
            AddForeignKey("dbo.ProperResultsQuestions", "AssessedParticipantsInGroupsID", "dbo.ParticipantsInGroups", "ID", cascadeDelete: true);
            DropColumn("dbo.ProperResults", "AssessedParticipantsInGroupsID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProperResults", "AssessedParticipantsInGroupsID", c => c.Int(nullable: false));
            DropForeignKey("dbo.ProperResultsQuestions", "AssessedParticipantsInGroupsID", "dbo.ParticipantsInGroups");
            DropIndex("dbo.ProperResultsQuestions", new[] { "AssessedParticipantsInGroupsID" });
            DropColumn("dbo.ProperResultsQuestions", "AssessedParticipantsInGroupsID");
            CreateIndex("dbo.ProperResults", "AssessedParticipantsInGroupsID");
            AddForeignKey("dbo.ProperResults", "AssessedParticipantsInGroupsID", "dbo.ParticipantsInGroups", "ID", cascadeDelete: true);
        }
    }
}
