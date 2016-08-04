namespace EF.DataAccess.MigrationsBaga
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "baga.Destinations",
                c => new
                    {
                        DestinationId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Country = c.String(),
                        Description = c.String(),
                        Photo = c.Binary(),
                    })
                .PrimaryKey(t => t.DestinationId);
            
            CreateTable(
                "baga.Lodgings",
                c => new
                    {
                        LodgingId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Owner = c.String(),
                        IsResort = c.Boolean(nullable: false),
                        Destination_DestinationId = c.Int(),
                    })
                .PrimaryKey(t => t.LodgingId)
                .ForeignKey("baga.Destinations", t => t.Destination_DestinationId)
                .Index(t => t.Destination_DestinationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("baga.Lodgings", "Destination_DestinationId", "baga.Destinations");
            DropIndex("baga.Lodgings", new[] { "Destination_DestinationId" });
            DropTable("baga.Lodgings");
            DropTable("baga.Destinations");
        }
    }
}
