namespace poki.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableNames : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.participants", "PersonID", "dbo.Persons");
            DropForeignKey("dbo.results", "ParticipantID", "dbo.Persons");
            DropForeignKey("dbo.participants", "GrupaID", "dbo.groups");
            DropIndex("dbo.participants", new[] { "GrupaID" });
            DropIndex("dbo.participants", new[] { "PersonID" });
     
      //CreateTable(
      //    "dbo.Groups",
      //    c => new
      //        {
      //            ID = c.Int(nullable: false, identity: true),
      //            Name = c.String(nullable: false, maxLength: 50),
      //            CreationDate = c.DateTime(nullable: false, storeType: "date"),
      //        })
      //    .PrimaryKey(t => t.ID);

      CreateTable(
                "dbo.GroupsOfParticipants",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GroupID = c.Int(nullable: false),
                        ParticipantID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Participants", t => t.ParticipantID)
                .ForeignKey("dbo.Groups", t => t.GroupID)
                .Index(t => t.GroupID)
                .Index(t => t.ParticipantID);
            
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        NickName = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        Picture = c.Binary(),
                        PESEL = c.String(nullable: false, maxLength: 11, fixedLength: true),
                    })
                .PrimaryKey(t => t.ID);
            
            AddForeignKey("dbo.Results", "ParticipantID", "dbo.Participants", "ID");
           DropTable("dbo.groups");
      DropTable("dbo.participants");
      DropTable("dbo.Persons");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        NickName = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        Picture = c.Binary(),
                        PESEL = c.String(nullable: false, maxLength: 11, fixedLength: true),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.participants",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GrupaID = c.Int(nullable: false),
                        PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.groups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        CreationDate = c.DateTime(nullable: false, storeType: "date"),
                    })
                .PrimaryKey(t => t.ID);
            
            DropForeignKey("dbo.GroupsOfParticipants", "GrupaID", "dbo.Groups");
            DropForeignKey("dbo.Results", "ParticipantID", "dbo.Participants");
            DropForeignKey("dbo.GroupsOfParticipants", "PersonID", "dbo.Participants");
            DropIndex("dbo.GroupsOfParticipants", new[] { "PersonID" });
            DropIndex("dbo.GroupsOfParticipants", new[] { "GrupaID" });
            DropTable("dbo.Participants");
            DropTable("dbo.GroupsOfParticipants");
            DropTable("dbo.Groups");
            CreateIndex("dbo.participants", "PersonID");
            CreateIndex("dbo.participants", "GrupaID");
            AddForeignKey("dbo.participants", "GrupaID", "dbo.groups", "ID");
            AddForeignKey("dbo.results", "ParticipantID", "dbo.Persons", "ID");
            AddForeignKey("dbo.participants", "PersonID", "dbo.Persons", "ID");
        }
    }
}
