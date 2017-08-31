namespace poki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveConnectionResult : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Results", "Participants_ID", "dbo.Participants");
            DropIndex("dbo.Results", new[] { "Participants_ID" });
            DropColumn("dbo.Results", "Participants_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Results", "Participants_ID", c => c.Int());
            CreateIndex("dbo.Results", "Participants_ID");
            AddForeignKey("dbo.Results", "Participants_ID", "dbo.Participants", "ID");
        }
    }
}
