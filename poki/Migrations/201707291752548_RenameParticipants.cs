namespace poki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameParticipants : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Participants", newName: "Participants");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Participants", newName: "Participants");
        }
    }
}
