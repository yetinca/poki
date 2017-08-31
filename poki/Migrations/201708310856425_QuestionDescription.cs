namespace poki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuestionDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Questions", "QuestionDescription", c => c.String(maxLength: 250));
            AlterColumn("dbo.Questions", "QuestionText", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Questions", "QuestionText", c => c.String(maxLength: 250));
            DropColumn("dbo.Questions", "QuestionDescription");
        }
    }
}
