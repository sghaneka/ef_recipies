namespace EF.DataAccess.MigrationsBaga
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("baga.Destinations", "Name", c => c.String(nullable: false));
            AlterColumn("baga.Destinations", "Country", c => c.String(maxLength: 500));
            AlterColumn("baga.Destinations", "Photo", c => c.Binary(storeType: "image"));
        }
        
        public override void Down()
        {
            AlterColumn("baga.Destinations", "Photo", c => c.Binary());
            AlterColumn("baga.Destinations", "Country", c => c.String());
            AlterColumn("baga.Destinations", "Name", c => c.String());
        }
    }
}
