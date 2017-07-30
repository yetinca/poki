namespace poki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyParticipantsInGroup : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ParticipantsInGroups", name: "PersonID", newName: "ParticipantsID");
            RenameColumn(table: "dbo.ParticipantsInGroups", name: "GrupaID", newName: "GroupsID");
            //RenameIndex(table: "dbo.ParticipantsInGroups", name: "IX_GrupaID", newName: "IX_GroupsID");
            //RenameIndex(table: "dbo.ParticipantsInGroups", name: "IX_PersonID", newName: "IX_ParticipantsID");
        }
        
        public override void Down()
        {
            //RenameIndex(table: "dbo.ParticipantsInGroups", name: "IX_ParticipantsID", newName: "IX_PersonID");
            //RenameIndex(table: "dbo.ParticipantsInGroups", name: "IX_GroupsID", newName: "IX_GrupaID");
            RenameColumn(table: "dbo.ParticipantsInGroups", name: "GroupsID", newName: "GrupaID");
            RenameColumn(table: "dbo.ParticipantsInGroups", name: "ParticipantsID", newName: "PersonID");
        }
    }
}
