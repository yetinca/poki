namespace poki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameParticipantsInGroup : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ParticipantsInGroup", newName: "ParticipantsInGroups");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ParticipantsInGroups", newName: "ParticipantsInGroup");
        }
    }
}
