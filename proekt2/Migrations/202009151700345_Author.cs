namespace proekt2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Author : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ArtWorks", "artist_Id", c => c.Int());
            CreateIndex("dbo.ArtWorks", "artist_Id");
            AddForeignKey("dbo.ArtWorks", "artist_Id", "dbo.Artists", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ArtWorks", "artist_Id", "dbo.Artists");
            DropIndex("dbo.ArtWorks", new[] { "artist_Id" });
            AlterColumn("dbo.ArtWorks", "artist_Id", c => c.Int(nullable: false));
        }
    }
}
