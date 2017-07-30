namespace poki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyRelationInResults : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Results", "ParticipantsInGroup_ID", "dbo.ParticipantsInGroups");
            DropIndex("dbo.Results", new[] { "ParticipantsInGroup_ID" });
            RenameColumn(table: "dbo.Results", name: "ParticipantsInGroup_ID", newName: "ParticipantsInGroupID");
            AlterColumn("dbo.Results", "ParticipantsInGroupID", c => c.Int(nullable: false));
            CreateIndex("dbo.Results", "ParticipantsInGroupID");
            AddForeignKey("dbo.Results", "ParticipantsInGroupID", "dbo.ParticipantsInGroups", "ID", cascadeDelete: true);
            DropColumn("dbo.Results", "ParticipantID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Results", "ParticipantID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Results", "ParticipantsInGroupID", "dbo.ParticipantsInGroups");
            DropIndex("dbo.Results", new[] { "ParticipantsInGroupID" });
            AlterColumn("dbo.Results", "ParticipantsInGroupID", c => c.Int());
            RenameColumn(table: "dbo.Results", name: "ParticipantsInGroupID", newName: "ParticipantsInGroup_ID");
            CreateIndex("dbo.Results", "ParticipantsInGroup_ID");
            AddForeignKey("dbo.Results", "ParticipantsInGroup_ID", "dbo.ParticipantsInGroups", "ID");
        }
    }
}
