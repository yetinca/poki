namespace poki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectRelationsResults : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Results", "ParticipantID", c => c.Int(nullable: false));
            AlterColumn("dbo.AccessLogins", "Login", c => c.String(nullable: false, maxLength: 50));
            DropColumn("dbo.Results", "ParticipantsInGroupsID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Results", "ParticipantsInGroupsID", c => c.Int(nullable: false));
            AlterColumn("dbo.AccessLogins", "Login", c => c.String());
            DropColumn("dbo.Results", "ParticipantID");
        }
    }
}
