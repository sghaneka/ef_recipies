namespace EF.DataAccess.Migrations.Albums
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "alb.Albums",
                c => new
                    {
                        AlbumId = c.Int(nullable: false, identity: true),
                        AlbumName = c.String(),
                    })
                .PrimaryKey(t => t.AlbumId);
            
            CreateTable(
                "alb.Artists",
                c => new
                    {
                        ArtistId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.ArtistId);
            
            CreateTable(
                "alb.ArtistAlbums",
                c => new
                    {
                        Artist_ArtistId = c.Int(nullable: false),
                        Album_AlbumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Artist_ArtistId, t.Album_AlbumId })
                .ForeignKey("alb.Artists", t => t.Artist_ArtistId, cascadeDelete: true)
                .ForeignKey("alb.Albums", t => t.Album_AlbumId, cascadeDelete: true)
                .Index(t => t.Artist_ArtistId)
                .Index(t => t.Album_AlbumId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("alb.ArtistAlbums", "Album_AlbumId", "alb.Albums");
            DropForeignKey("alb.ArtistAlbums", "Artist_ArtistId", "alb.Artists");
            DropIndex("alb.ArtistAlbums", new[] { "Album_AlbumId" });
            DropIndex("alb.ArtistAlbums", new[] { "Artist_ArtistId" });
            DropTable("alb.ArtistAlbums");
            DropTable("alb.Artists");
            DropTable("alb.Albums");
        }
    }
}
