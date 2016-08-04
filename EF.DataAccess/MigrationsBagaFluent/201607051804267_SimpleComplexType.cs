namespace EF.DataAccess.MigrationsBagaFluent
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SimpleComplexType : DbMigration
    {
        public override void Up()
        {
            AddColumn("bf.People", "Address_StreetAddress", c => c.String());
            AddColumn("bf.People", "Address_City", c => c.String());
            AddColumn("bf.People", "Address_State", c => c.String());
            AddColumn("bf.People", "Address_ZipCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("bf.People", "Address_ZipCode");
            DropColumn("bf.People", "Address_State");
            DropColumn("bf.People", "Address_City");
            DropColumn("bf.People", "Address_StreetAddress");
        }
    }
}
