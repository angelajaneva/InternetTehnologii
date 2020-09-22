namespace proekt2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedBiography : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.ArtWorks", new[] { "artist_Id" });
            AddColumn("dbo.Artists", "biography", c => c.String());
            AlterColumn("dbo.ArtWorks", "artist_Id", c => c.Int());
            AlterColumn("dbo.ArtWorks", "artist_id", c => c.Int(nullable: false));
            CreateIndex("dbo.ArtWorks", "artist_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.ArtWorks", new[] { "artist_Id" });
            AlterColumn("dbo.ArtWorks", "artist_id", c => c.Int());
            AlterColumn("dbo.ArtWorks", "artist_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Artists", "biography");
            CreateIndex("dbo.ArtWorks", "artist_Id");
        }
    }
}
