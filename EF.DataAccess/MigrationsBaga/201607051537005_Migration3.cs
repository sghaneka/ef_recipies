namespace EF.DataAccess.MigrationsBaga
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "baga.People",
                c => new
                    {
                        SocialSecurityNumber = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.SocialSecurityNumber);
            
        }
        
        public override void Down()
        {
            DropTable("baga.People");
        }
    }
}
