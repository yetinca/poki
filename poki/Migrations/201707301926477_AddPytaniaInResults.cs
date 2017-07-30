namespace poki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPytaniaInResults : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Results", "Pytanie4", c => c.Short(nullable: false));
            AddColumn("dbo.Results", "Pytanie5", c => c.Short(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Results", "Pytanie5");
            DropColumn("dbo.Results", "Pytanie4");
        }
    }
}
