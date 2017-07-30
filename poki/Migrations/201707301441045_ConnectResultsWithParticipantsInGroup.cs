namespace poki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConnectResultsWithParticipantsInGroup : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Results", new[] { "ParticipantID" });
            RenameColumn(table: "dbo.Results", name: "ParticipantID", newName: "Participants_ID");
            AddColumn("dbo.Results", "ParticipantsInGroupsID", c => c.Int(nullable: false));
            AddColumn("dbo.Results", "ParticipantsInGroup_ID", c => c.Int());
            AlterColumn("dbo.Results", "Participants_ID", c => c.Int());
            CreateIndex("dbo.Results", "ParticipantsInGroup_ID");
            CreateIndex("dbo.Results", "Participants_ID");
            AddForeignKey("dbo.Results", "ParticipantsInGroup_ID", "dbo.ParticipantsInGroups", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Results", "ParticipantsInGroup_ID", "dbo.ParticipantsInGroups");
            DropIndex("dbo.Results", new[] { "Participants_ID" });
            DropIndex("dbo.Results", new[] { "ParticipantsInGroup_ID" });
            AlterColumn("dbo.Results", "Participants_ID", c => c.Int(nullable: false));
            DropColumn("dbo.Results", "ParticipantsInGroup_ID");
            DropColumn("dbo.Results", "ParticipantsInGroupsID");
            RenameColumn(table: "dbo.Results", name: "Participants_ID", newName: "ParticipantID");
            CreateIndex("dbo.Results", "ParticipantID");
        }
    }
}
