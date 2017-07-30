namespace poki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDescriptionToResults : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DescriptionToResults",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ResultsID = c.Int(nullable: false),
                        ParticipantID = c.Int(nullable: false),
                        Text = c.String(nullable: false),
                        Participants_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Participants", t => t.Participants_ID)
                .ForeignKey("dbo.Results", t => t.ResultsID, cascadeDelete: true)
                .Index(t => t.ResultsID)
                .Index(t => t.Participants_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DescriptionToResults", "ResultsID", "dbo.Results");
            DropForeignKey("dbo.DescriptionToResults", "Participants_ID", "dbo.Participants");
            DropIndex("dbo.DescriptionToResults", new[] { "Participants_ID" });
            DropIndex("dbo.DescriptionToResults", new[] { "ResultsID" });
            DropTable("dbo.DescriptionToResults");
        }
    }
}
