namespace EF.DataAccess.MigrationsBaga
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SimpleComplexType : DbMigration
    {
        public override void Up()
        {
            AddColumn("baga.People", "Address_StreetAddress", c => c.String());
            AddColumn("baga.People", "Address_City", c => c.String());
            AddColumn("baga.People", "Address_State", c => c.String());
            AddColumn("baga.People", "Address_ZipCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("baga.People", "Address_ZipCode");
            DropColumn("baga.People", "Address_State");
            DropColumn("baga.People", "Address_City");
            DropColumn("baga.People", "Address_StreetAddress");
        }
    }
}
