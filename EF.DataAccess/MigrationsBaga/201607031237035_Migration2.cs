namespace EF.DataAccess.MigrationsBaga
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "baga.Trips",
                c => new
                    {
                        Identifier = c.Guid(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        CostUSD = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Identifier);
            
        }
        
        public override void Down()
        {
            DropTable("baga.Trips");
        }
    }
}
