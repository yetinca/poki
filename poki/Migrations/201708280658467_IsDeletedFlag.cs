namespace poki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsDeletedFlag : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Participants", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Groups", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Groups", "IsDeleted");
            DropColumn("dbo.Participants", "IsDeleted");
        }
    }
}
