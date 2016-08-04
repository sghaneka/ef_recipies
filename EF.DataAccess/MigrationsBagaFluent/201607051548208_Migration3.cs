namespace EF.DataAccess.MigrationsBagaFluent
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "bf.People",
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
            DropTable("bf.People");
        }
    }
}
