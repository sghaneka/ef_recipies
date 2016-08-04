namespace EF.DataAccess.MigrationsBaga
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InverseProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("baga.Lodgings", "PrimaryContactFor_SocialSecurityNumber", c => c.Int());
            AddColumn("baga.Lodgings", "SecondaryContactFor_SocialSecurityNumber", c => c.Int());
            CreateIndex("baga.Lodgings", "PrimaryContactFor_SocialSecurityNumber");
            CreateIndex("baga.Lodgings", "SecondaryContactFor_SocialSecurityNumber");
            AddForeignKey("baga.Lodgings", "PrimaryContactFor_SocialSecurityNumber", "baga.People", "SocialSecurityNumber");
            AddForeignKey("baga.Lodgings", "SecondaryContactFor_SocialSecurityNumber", "baga.People", "SocialSecurityNumber");
        }
        
        public override void Down()
        {
            DropForeignKey("baga.Lodgings", "SecondaryContactFor_SocialSecurityNumber", "baga.People");
            DropForeignKey("baga.Lodgings", "PrimaryContactFor_SocialSecurityNumber", "baga.People");
            DropIndex("baga.Lodgings", new[] { "SecondaryContactFor_SocialSecurityNumber" });
            DropIndex("baga.Lodgings", new[] { "PrimaryContactFor_SocialSecurityNumber" });
            DropColumn("baga.Lodgings", "SecondaryContactFor_SocialSecurityNumber");
            DropColumn("baga.Lodgings", "PrimaryContactFor_SocialSecurityNumber");
        }
    }
}
