namespace proekt2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AuthorsonArtworks2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ArtWorks", "artist_Id", "dbo.Artists");
            DropIndex("dbo.ArtWorks", new[] { "artist_Id" });
            AlterColumn("dbo.ArtWorks", "artist_id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ArtWorks", "artist_id", c => c.Int());
            CreateIndex("dbo.ArtWorks", "artist_Id");
            AddForeignKey("dbo.ArtWorks", "artist_Id", "dbo.Artists", "Id");
        }
    }
}
