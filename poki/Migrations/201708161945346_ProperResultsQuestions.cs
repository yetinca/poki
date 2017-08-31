namespace poki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProperResultsQuestions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProperResults",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AssessingParticipantsInGroupsID = c.Int(nullable: false),
                        AssessedParticipantsInGroupsID = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ParticipantsInGroups", t => t.AssessedParticipantsInGroupsID, cascadeDelete: false)
                .ForeignKey("dbo.ParticipantsInGroups", t => t.AssessingParticipantsInGroupsID, cascadeDelete: false)
                .Index(t => t.AssessingParticipantsInGroupsID)
                .Index(t => t.AssessedParticipantsInGroupsID);
            
            CreateTable(
                "dbo.ProperResultsQuestions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProperResultID = c.Int(nullable: false),
                        QuestionID = c.Int(nullable: false),
                        QuestionValue = c.Byte(),
                        QuestionText = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ProperResults", t => t.ProperResultID, cascadeDelete: false)
                .ForeignKey("dbo.Questions", t => t.QuestionID, cascadeDelete: false)
                .Index(t => t.ProperResultID)
                .Index(t => t.QuestionID);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        QuestionText = c.String(maxLength: 250),
                        OrderNumber = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Type = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProperResultsQuestions", "QuestionID", "dbo.Questions");
            DropForeignKey("dbo.ProperResultsQuestions", "ProperResultID", "dbo.ProperResults");
            DropForeignKey("dbo.ProperResults", "AssessingParticipantsInGroupsID", "dbo.ParticipantsInGroups");
            DropForeignKey("dbo.ProperResults", "AssessedParticipantsInGroupsID", "dbo.ParticipantsInGroups");
            DropIndex("dbo.ProperResultsQuestions", new[] { "QuestionID" });
            DropIndex("dbo.ProperResultsQuestions", new[] { "ProperResultID" });
            DropIndex("dbo.ProperResults", new[] { "AssessedParticipantsInGroupsID" });
            DropIndex("dbo.ProperResults", new[] { "AssessingParticipantsInGroupsID" });
            DropTable("dbo.Questions");
            DropTable("dbo.ProperResultsQuestions");
            DropTable("dbo.ProperResults");
        }
    }
}
