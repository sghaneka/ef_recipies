namespace EF.DataAccess.MigrationsBagaFluent
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "bf.Destinations",
                c => new
                    {
                        DestinationId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Country = c.String(),
                        Description = c.String(maxLength: 500),
                        Photo = c.Binary(storeType: "image"),
                    })
                .PrimaryKey(t => t.DestinationId);
            
            CreateTable(
                "bf.Lodgings",
                c => new
                    {
                        LodgingId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Owner = c.String(),
                        IsResort = c.Boolean(nullable: false),
                        Destination_DestinationId = c.Int(),
                    })
                .PrimaryKey(t => t.LodgingId)
                .ForeignKey("bf.Destinations", t => t.Destination_DestinationId)
                .Index(t => t.Destination_DestinationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("bf.Lodgings", "Destination_DestinationId", "bf.Destinations");
            DropIndex("bf.Lodgings", new[] { "Destination_DestinationId" });
            DropTable("bf.Lodgings");
            DropTable("bf.Destinations");
        }
    }
}
