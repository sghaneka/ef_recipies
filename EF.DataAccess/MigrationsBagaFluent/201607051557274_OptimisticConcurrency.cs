namespace EF.DataAccess.MigrationsBagaFluent
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OptimisticConcurrency : DbMigration
    {
        public override void Up()
        {
            AddColumn("bf.People", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("bf.Trips", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("bf.Trips", "RowVersion");
            DropColumn("bf.People", "RowVersion");
        }
    }
}
