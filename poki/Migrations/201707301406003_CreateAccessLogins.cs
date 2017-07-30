namespace poki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAccessLogins : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccessLogins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AccessLogins");
        }
    }
}
