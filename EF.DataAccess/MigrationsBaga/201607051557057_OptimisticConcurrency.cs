namespace EF.DataAccess.MigrationsBaga
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OptimisticConcurrency : DbMigration
    {
        public override void Up()
        {
            AddColumn("baga.People", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("baga.Trips", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("baga.Trips", "RowVersion");
            DropColumn("baga.People", "RowVersion");
        }
    }
}
