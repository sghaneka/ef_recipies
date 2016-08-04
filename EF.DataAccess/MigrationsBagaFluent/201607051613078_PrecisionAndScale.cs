namespace EF.DataAccess.MigrationsBagaFluent
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrecisionAndScale : DbMigration
    {
        public override void Up()
        {
            AddColumn("bf.Lodgings", "MilesFromNearestAirport", c => c.Decimal(nullable: false, precision: 8, scale: 1));
        }
        
        public override void Down()
        {
            DropColumn("bf.Lodgings", "MilesFromNearestAirport");
        }
    }
}
