namespace EF.DataAccess.MigrationsBaga
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ComplexComplexType : DbMigration
    {
        public override void Up()
        {
            AddColumn("baga.People", "Info_Weight_Reading", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("baga.People", "Info_Weight_Units", c => c.String());
            AddColumn("baga.People", "Info_Height_Reading", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("baga.People", "Info_Height_Units", c => c.String());
            AddColumn("baga.People", "Info_DietryRestrictions", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("baga.People", "Info_DietryRestrictions");
            DropColumn("baga.People", "Info_Height_Units");
            DropColumn("baga.People", "Info_Height_Reading");
            DropColumn("baga.People", "Info_Weight_Units");
            DropColumn("baga.People", "Info_Weight_Reading");
        }
    }
}
