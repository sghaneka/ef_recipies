namespace EF.DataAccess.Migrations.Poetry
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Meters",
                c => new
                    {
                        MeterId = c.Int(nullable: false, identity: true),
                        MeterName = c.String(),
                    })
                .PrimaryKey(t => t.MeterId);
            
            CreateTable(
                "dbo.Poems",
                c => new
                    {
                        PoemId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        MeterId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PoemId);
            
            CreateTable(
                "dbo.Poets",
                c => new
                    {
                        PoetId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.PoetId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Poets");
            DropTable("dbo.Poems");
            DropTable("dbo.Meters");
        }
    }
}
