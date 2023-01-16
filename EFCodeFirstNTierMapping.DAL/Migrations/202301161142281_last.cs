namespace EFCodeFirstNTierMapping.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class last : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ActorFilm",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        WorkDays = c.Int(nullable: false),
                        ActorID = c.Int(nullable: false),
                        FilmID = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Actor", t => t.FilmID, cascadeDelete: true)
                .ForeignKey("dbo.Films", t => t.ActorID, cascadeDelete: true)
                .Index(t => t.ActorID)
                .Index(t => t.FilmID);
            
            CreateTable(
                "dbo.Actor",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ActorName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        LifeOfActor = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FilmName = c.String(nullable: false, maxLength: 65),
                        VisionDate = c.DateTime(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FilmCategory", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.FilmCategory",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FilmDetail",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        DetailOfFilm = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Films", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ActorFilm", "ActorID", "dbo.Films");
            DropForeignKey("dbo.FilmDetail", "ID", "dbo.Films");
            DropForeignKey("dbo.Films", "CategoryID", "dbo.FilmCategory");
            DropForeignKey("dbo.ActorFilm", "FilmID", "dbo.Actor");
            DropIndex("dbo.FilmDetail", new[] { "ID" });
            DropIndex("dbo.Films", new[] { "CategoryID" });
            DropIndex("dbo.ActorFilm", new[] { "FilmID" });
            DropIndex("dbo.ActorFilm", new[] { "ActorID" });
            DropTable("dbo.FilmDetail");
            DropTable("dbo.FilmCategory");
            DropTable("dbo.Films");
            DropTable("dbo.Actor");
            DropTable("dbo.ActorFilm");
        }
    }
}
