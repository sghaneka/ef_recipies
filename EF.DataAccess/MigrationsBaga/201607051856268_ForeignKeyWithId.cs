namespace EF.DataAccess.MigrationsBaga
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKeyWithId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("baga.Lodgings", "Destination_DestinationId", "baga.Destinations");
            DropIndex("baga.Lodgings", new[] { "Destination_DestinationId" });
            RenameColumn(table: "baga.Lodgings", name: "Destination_DestinationId", newName: "DestinationId");
            AlterColumn("baga.Lodgings", "DestinationId", c => c.Int(nullable: false));
            CreateIndex("baga.Lodgings", "DestinationId");
            AddForeignKey("baga.Lodgings", "DestinationId", "baga.Destinations", "DestinationId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("baga.Lodgings", "DestinationId", "baga.Destinations");
            DropIndex("baga.Lodgings", new[] { "DestinationId" });
            AlterColumn("baga.Lodgings", "DestinationId", c => c.Int());
            RenameColumn(table: "baga.Lodgings", name: "DestinationId", newName: "Destination_DestinationId");
            CreateIndex("baga.Lodgings", "Destination_DestinationId");
            AddForeignKey("baga.Lodgings", "Destination_DestinationId", "baga.Destinations", "DestinationId");
        }
    }
}
